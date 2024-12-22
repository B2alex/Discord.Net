using Discord.Models;
using Discord.Rest;
using Discord.Rest.Pipeline;

namespace Discord;

#pragma warning disable CS9113 // Parameter is unread.

[AttributeUsage(AttributeTargets.Interface)]
internal sealed class RefreshableAttribute : Attribute;

[AttributeUsage(AttributeTargets.Interface)]
internal sealed class RefreshableAttribute<TRoute> : Attribute
    where TRoute : IRouteOperation<TRoute>;

#pragma warning restore CS9113 // Parameter is unread.

[TemplateExtension]
public interface IRefreshable<in TSelf, TRoute, TModel> :
    IFetchable<TRoute, TModel>,
    IUpdatable<TModel>,
    IPathable,
    IClientProvider
    where TModel : class, IModel
    where TRoute : IRouteOperation<TRoute>
    where TSelf : IRefreshable<TSelf, TRoute, TModel>
{
    async Task RefreshAsync(RequestOptions? options = null, CancellationToken token = default)
    {
        await TRoute.Create(this)
            .AsPipeline(options)
            .Deserialize<TModel>()
            .IfNotNull()
            .Continue(UpdateAsync)
            .RunAsync(Client, token);
    }
}