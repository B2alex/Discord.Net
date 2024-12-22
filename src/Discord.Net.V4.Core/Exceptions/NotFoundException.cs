using Discord.Rest;

namespace Discord;

public class NotFoundException(IRouteOperation route, RequestOptions? options) :
    DiscordHttpException(route, options, message: "Not found");
