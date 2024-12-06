using System.Text;
using Discord.Net.Hanz.Tasks.Actors.Common;
using Discord.Net.Hanz.Tasks.Actors.Nodes;
using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;

namespace Discord.Net.Hanz.Tasks.Actors.TraitsV2.Nodes;

using ExtensionGenerationDetails =
    (
    CreatableTraitNode.CreatableTraitState State,
    ImmutableEquatableArray<(
        TraitImplementationTarget BackLink,
        CreatableTraitNode.TraitDetails Details
        )> Targets
    );

public sealed partial class CreatableTraitNode
{
    private IncrementalKeyValueProvider<TraitImplementationTarget, TypeSpec> CreateExtensionsProvider()
    {
        return State
            .MapValues((key, state) =>
                (
                    State: state,
                    BackLinks: state.Details
                        .SelectMany(x => x
                            .FromBackLinks
                            .Select(y =>
                                (BackLink: y, Details: x)
                            )
                        )
                        .ToImmutableEquatableArray()
                )
            )
            .Where(x => x.BackLinks.Count > 0)
            .MapValues(CreateExtensionSpec);
    }

    private TypeSpec CreateExtensionSpec(
        TraitImplementationTarget target,
        ExtensionGenerationDetails details
    )
    {
        var (state, targets) = details;

        Logger.Log($"Creating extension for {state.Target}, {targets.Count} targets");
        Logger.Flush();


        return new TypeSpec(
            $"Creatable{GetFriendlyName(target.Type)}Extensions",
            TypeKind.Class,
            Modifiers: new(["static"]),
            Methods: targets
                .Select(x => CreateExtensionMethodSpec(target, x.Details, x.BackLink))
                .ToImmutableEquatableArray()
        );
    }

    private MethodSpec CreateExtensionMethodSpec(
        TraitImplementationTarget target,
        TraitDetails detail,
        TraitImplementationTarget backlink)
    {
        var extensionTarget = detail.Kind switch
        {
            CreatableKind.Actor => $"{target.Type}.BackLink<{backlink.Type}>",
            CreatableKind.Link => target.FormattedBackLinkOfType(backlink.Type),
            _ => throw new InvalidOperationException($"Unknown creatable kind {detail.Kind}")
        };

        var parameters = new List<ParameterSpec>()
        {
            ($"this {extensionTarget}", "link")
        };

        var body = new StringBuilder();

        if (detail.Properties is not null)
        {
            parameters.Add((detail.Properties.Value.Source.Type.DisplayString, "args"));
        }

        parameters.AddRange([
            ("RequestOptions", "options", "null"),
            ("CancellationToken", "token", "default"),
        ]);

        body.AppendLine(
            $$"""
              var model = await link.Client.RestApiClient.ExecuteRequiredAsync(
                  {{target.Type}}.CreateRoute(link, args.ToApiModel()),
                  options,
                  token
              );

              return await link.CreateEntityAsync(model);
              """
        );

        return new MethodSpec(
            detail.MethodName,
            $"Task<{target.Entity}>",
            Accessibility.Public,
            new(["static", "async"]),
            new(parameters),
            Body: body.ToString()
        );

        string? ResolveRouteParameter(RouteParameter parameter)
        {
            if (detail.Properties.HasValue && detail.Properties.Value.Source.ParamsType.Equals(parameter.Type))
                return "args.ToApiModel()";

            // TODO: use relationships somehow
            if (parameter.Heuristics.Count == 0)
                return null;

            return $"path.Require<{parameter.Heuristics[0]}>()";

            // foreach (var heuristic in parameter.Heuristics)
            // {
            //     if (
            //         GetNode<ActorNode>().TryGetPathingTo(
            //             backlink,
            //             x =>
            //                 x.Actor.Equals(heuristic) ||
            //                 x.Entity.Equals(heuristic),
            //             out var pathing
            //         )
            //     )
            //     {
            //         var sb = new StringBuilder("link.Source");
            //
            //         foreach (var part in pathing)
            //         {
            //             sb.Append('.').Append(GetNode<ActorNode>().GetRelationshipName(part.To));
            //         }
            //
            //         return sb.Append(".Id").ToString();
            //     }
            // }

            return null;
        }
    }
}