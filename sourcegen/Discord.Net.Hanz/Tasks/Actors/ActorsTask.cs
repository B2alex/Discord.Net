using Discord.Net.Hanz.Utils;
using Discord.Net.Hanz.Utils.Bakery;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.Actors;

public record AncestorInfo(
    ActorInfo ActorInfo,
    bool IsEntityAssignable
);

public class ActorsTask : GenerationTask
{
    public static readonly string[] AllowedAssemblies =
    [
        "Discord.Net.V4.Core",
        "Discord.Net.V4.Rest"
    ];

    public sealed class ActorSymbols(
        SemanticModel semanticModel,
        TypeDeclarationSyntax syntax,
        INamedTypeSymbol entity,
        INamedTypeSymbol actor,
        INamedTypeSymbol model,
        ITypeSymbol id,
        AssemblyTarget assembly
    ) : IEquatable<ActorSymbols>
    {
        public SemanticModel SemanticModel { get; private set; } = semanticModel;
        public TypeDeclarationSyntax Syntax { get; } = syntax;
        public INamedTypeSymbol Entity { get; } = entity;
        public INamedTypeSymbol Actor { get; } = actor;
        public INamedTypeSymbol Model { get; } = model;
        public ITypeSymbol Id { get; } = id;
        public AssemblyTarget Assembly { get; } = assembly;

        public bool Equals(ActorSymbols other)
            => GetHashCode() == other.GetHashCode();

        public override int GetHashCode()
            => HashCode
                .Of(Actor.ToDisplayString())
                .And((int) Assembly)
                .AndEach(Actor
                    .GetAttributes()
                    .Select(x => HashCode
                        .Of(x.AttributeClass?.ToDisplayString())
                    )
                );

        public INamedTypeSymbol GetCoreActor()
        {
            if (Assembly is AssemblyTarget.Core) return Actor;

            return Hierarchy.GetHierarchy(Actor, false)
                .First(x =>
                    x.Type.ContainingAssembly.Name == "Discord.Net.V4.Core"
                    &&
                    x.Type.AllInterfaces.Any(y => y is {Name: "IActor", TypeArguments.Length: 2})
                ).Type;
        }

        public INamedTypeSymbol GetCoreEntity()
        {
            if (Assembly is AssemblyTarget.Core) return Entity;

            return Hierarchy.GetHierarchy(Entity, false)
                .First(x =>
                    x.Type.ContainingAssembly.Name == "Discord.Net.V4.Core"
                    &&
                    x.Type.AllInterfaces.Any(y => y is {Name: "IEntity"})
                ).Type;
        }
    }

    public sealed class ActorHierarchy : IEquatable<ActorHierarchy>
    {
        public ActorInfo ActorInfo { get; init; }
        public ImmutableEquatableArray<AncestorInfo> ParentInfos { get; init; }
        public ImmutableEquatableArray<ActorInfo> ChildrenInfos { get; init; }

        public bool HasEntityAssignableAncestors => ParentInfos.Any(x => x.IsEntityAssignable);

        public IEnumerable<ActorHierarchy> Parents
            => ParentInfos
                .Select(x => _actorsTask.ActorHierarchies.GetValueOrDefault(x.ActorInfo))
                .Where(x => x is not null)!;

        public ImmutableEquatableArray<ActorInfo> EntityAssignableAncestors
            => _entityAssignableAncestors.Value;

        public IEnumerable<ActorHierarchy> Children
            => ChildrenInfos
                .Select(_actorsTask.ActorHierarchies.GetValueOrDefault)
                .Where(x => x is not null)!;

        public bool HasAncestors => ParentInfos.Count > 0;
        public bool HasChildren => ChildrenInfos.Count > 0;

        private readonly ActorsTask _actorsTask;

        private readonly Lazy<ImmutableEquatableArray<ActorInfo>> _entityAssignableAncestors;

        public ActorHierarchy(
            ActorsTask actorsTask,
            ActorInfo actorInfo,
            ImmutableEquatableArray<AncestorInfo> parentInfos,
            ImmutableEquatableArray<ActorInfo> childrenInfos)
        {
            _actorsTask = actorsTask;
            ActorInfo = actorInfo;
            ParentInfos = parentInfos;
            ChildrenInfos = childrenInfos;
            _entityAssignableAncestors = new(() =>
                parentInfos
                    .Where(x => x.IsEntityAssignable)
                    .Select(x => x.ActorInfo)
                    .ToImmutableEquatableArray()
            );
        }

        public bool Equals(ActorHierarchy? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return ActorInfo.Equals(other.ActorInfo) && ParentInfos.Equals(other.ParentInfos) &&
                   ChildrenInfos.Equals(other.ChildrenInfos);
        }

        public override bool Equals(object? obj)
        {
            return ReferenceEquals(this, obj) || obj is ActorHierarchy other && Equals(other);
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(ActorInfo, ParentInfos, ChildrenInfos);
        }

        public static bool operator ==(ActorHierarchy? left, ActorHierarchy? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ActorHierarchy? left, ActorHierarchy? right)
        {
            return !Equals(left, right);
        }
    }

    public IncrementalValuesProvider<ActorSymbols> Actors { get; }
    public IncrementalKeyValueProvider<string, ActorInfo> ActorInfos { get; }

    public IncrementalKeyValueProvider<ActorInfo, ImmutableEquatableArray<AncestorInfo>> ActorAncestors { get; }

    public IncrementalKeyValueProvider<ActorInfo, ActorHierarchy> ActorHierarchies { get; }

    public ActorsTask(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
    {
        Actors = context
            .SyntaxProvider
            .CreateSyntaxProvider(
                IsPossibleActorNode,
                GetPossibleActorSymbols
            )
            .WhereNotNull();

        ActorInfos = Actors
            .Select((x, _) => ActorInfo.Create(x))
            .KeyedBy(x => x.Actor.DisplayString)
            .WithLogging(
                Logger.GetSubLogger("ActorInfosTracing")
            );

        var keyedActors = Actors
            .KeyedBy(x => x.Actor.ToDisplayString());

        ActorAncestors = keyedActors
            .MapValues((_, symbols) => TypeUtils
                .GetBaseTypes(symbols.Actor)
                .Concat(symbols.Actor.AllInterfaces)
                .Where(x => keyedActors.ContainsKey(x.ToDisplayString()))
                .Select(x =>
                    {
                        var key = x.ToDisplayString();
                        var ancestorSymbols = keyedActors.GetValue(key);

                        return (
                            Ancestor: x.ToDisplayString(),
                            IsEntityAssignable: Hierarchy.Implements(symbols.Entity, ancestorSymbols.Entity) ||
                                                symbols.Entity.Equals(ancestorSymbols.Entity,
                                                    SymbolEqualityComparer.Default)
                        );
                    }
                )
                .ToImmutableEquatableArray()
            )
            .PairKeys(ActorInfos)
            .MapValues((_, ancestors) => ancestors
                .Select(x =>
                    new AncestorInfo(
                        ActorInfos.GetValue(x.Ancestor),
                        x.IsEntityAssignable
                    )
                )
                .ToImmutableEquatableArray()
            );

        ActorHierarchies = ActorAncestors
            .MapValues((info, ancestors) =>
                new ActorHierarchy(
                    this,
                    info,
                    ancestors,
                    ActorAncestors
                        .Entries
                        .Where(x => x.Value.Any(x => x.ActorInfo == info))
                        .Select(x => x.Key)
                        .ToImmutableEquatableArray()
                )
            );
    }

    public static AssemblyTarget? GetAssemblyTarget(
        Compilation compilation
    ) => GetAssemblyTarget(compilation.Assembly.Name);

    public static AssemblyTarget? GetAssemblyTarget(string name)
    {
        return name switch
        {
            "Discord.Net.V4.Core" => AssemblyTarget.Core,
            "Discord.Net.V4.Rest" => AssemblyTarget.Rest,
            _ => null
        };
    }

    public bool IsPossibleActorNode(SyntaxNode node, CancellationToken token)
    {
        if (node is not TypeDeclarationSyntax typeSyntax)
            return false;

        if (typeSyntax.Identifier.ValueText.ToLowerInvariant().Contains("trait"))
            return false;
        
        while (true)
        {
            if (typeSyntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
                return false;

            if (typeSyntax.Parent is not TypeDeclarationSyntax parent)
                return true;

            typeSyntax = parent;
        }
    }

    public ActorSymbols? GetPossibleActorSymbols(GeneratorSyntaxContext context, CancellationToken token)
    {
        if (!AllowedAssemblies.Contains(context.SemanticModel.Compilation.Assembly.Name)) return null;

        var assembly = GetAssemblyTarget(context.SemanticModel.Compilation) ?? throw new NotSupportedException();

        if (context.Node is not TypeDeclarationSyntax syntax)
            return null;

        if (ModelExtensions.GetDeclaredSymbol(context.SemanticModel, syntax) is not INamedTypeSymbol symbol)
            return null;

        var actorType = assembly switch
        {
            AssemblyTarget.Core => "IActor",
            AssemblyTarget.Rest => "IRestActor",
            _ => throw new NotSupportedException()
        };

        var actorInterface = Hierarchy.GetHierarchy(symbol)
            .Select(x => x.Type)
            .FirstOrDefault(x => x.Name == actorType && x is {TypeArguments.Length: 2});

        if (actorInterface is null)
            return null;

        // don't apply to entities
        if (
            actorInterface.TypeArguments[1].Equals(symbol, SymbolEqualityComparer.Default) ||
            actorInterface.TypeArguments[1] is not INamedTypeSymbol entity ||
            symbol.AllInterfaces.Contains(entity))
            return null;

        var entityOfInterface = Hierarchy.GetHierarchy(actorInterface.TypeArguments[1])
            .Select(x => x.Type)
            .FirstOrDefault(x => x is {Name: "IEntityOf", TypeArguments.Length: 1});

        if (entityOfInterface?.TypeArguments.FirstOrDefault() is not INamedTypeSymbol model)
            return null;

        if (syntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
        {
            return null;
        }

        var parent = syntax.Parent;

        while (parent is TypeDeclarationSyntax parentSyntax)
        {
            if (parentSyntax.Modifiers.IndexOf(SyntaxKind.PartialKeyword) == -1)
            {
                return null;
            }

            parent = parentSyntax.Parent;
        }

        return new ActorSymbols(
            context.SemanticModel,
            syntax,
            entity,
            symbol,
            model,
            actorInterface.TypeArguments[0],
            assembly
        );
    }
}