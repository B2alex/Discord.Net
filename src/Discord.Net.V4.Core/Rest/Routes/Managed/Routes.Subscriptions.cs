using Discord.Rest;

namespace Discord;

public partial class Routes
{
    public record ListSKUSubscriptions(
        ulong @SKUId
    ) : IRouteOperation<ListSKUSubscriptions>
    {
        public static string Path { get; } = "/skus/{sku.id}/subscriptions";
        public static string OperationName { get; } = "list_sku_subscriptions";
        public static RequestMethod Method { get; } = RequestMethod.Get;
        public static bool RequiresBotToken { get; } = true;

        public string BuildRoute()
            => $"/skus/{SKUId}/subscriptions";

        public static ListSKUSubscriptions Create(IPathable path)
            => new(path.Require<ISku>());
    }
    
    public record GetSKUSubscription(
        ulong @SKUId,
        ulong @SubscriptionId
    ) : IRouteOperation<GetSKUSubscription>
    {
        public static string Path { get; } = "/skus/{sku.id}/subscriptions/{subscription.id}";
        public static string OperationName { get; } = "get_sku_subscription";
        public static RequestMethod Method { get; } = RequestMethod.Get;
        public static bool RequiresBotToken { get; } = true;

        public string BuildRoute()
            => $"/skus/{SKUId}/subscriptions/{SubscriptionId}";

        public static GetSKUSubscription Create(IPathable path)
            => new(path.Require<ISku>(), path.Require<ISku>()); // TODO: subscription object
    }
}