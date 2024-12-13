using Discord.Models.Json;

namespace Discord.Rest;

public sealed class RouteTypeProvider : IRouteTypeMapper
{
    public IEnumerable<string> IgnoredRoutes => ["/applications/{application_id}/attachment"];
    
    public Type AddGroupDmUser201ResponseModel { get; } = typeof(Channel);
    public Type AddGroupDmUserRequestModel { get; } = typeof(GroupDmAddRecipientParams);
    public Type AddGuildMemberRequestModel { get; } = typeof(AddGuildMemberParams);
    public Type ApplicationCommandCreateRequest { get; } = typeof(CreateGlobalApplicationCommandParams);
    public Type ApplicationCommandPatchRequestPartial { get; } = typeof(ModifyGlobalApplicationCommandParams);
    public Type ApplicationCommandResponse { get; } = typeof(ApplicationCommand);
    public Type ApplicationFormPartial { get; } = typeof(ModifyCurrentApplicationParams);
    public Type ApplicationUserRoleConnectionResponse { get; } = typeof(ApplicationRoleConnection);
    public Type BanUserFromGuildRequestModel { get; } = typeof(CreateGuildBanParams);
    public Type BotAccountPatchRequest { get; } = typeof(ModifyCurrentUserParams);
    public Type BulkBanUsersFromGuildRequestModel { get; } = typeof(BulkBanUsersParams);
    public Type BulkBanUsersResponse { get; } = typeof(BulkBanResponse);
    public Type BulkDeleteMessagesRequestModel { get; } = typeof(BulkDeleteMessagesParams);
    
    public Type BulkSetApplicationCommands200ResponseModel { get; } =
        typeof(IEnumerable<ApplicationCommand>);

    public Type BulkSetApplicationCommandsRequestModel { get; } =
        typeof(IEnumerable<ModifyGlobalApplicationCommandParams>);

    public Type BulkSetGuildApplicationCommands200ResponseModel { get; } = typeof(IEnumerable<ApplicationCommand>);

    public Type BulkSetGuildApplicationCommandsRequestModel { get; } =
        typeof(IEnumerable<ModifyGuildApplicationCommandParams>);

    public Type BulkUpdateGuildChannelsRequestModel { get; } = typeof(IEnumerable<ModifyGuildChannelPositionsParams>);
    public Type BulkUpdateGuildRoles200ResponseModel { get; } = typeof(IEnumerable<Role>);
    public Type BulkUpdateGuildRolesRequestModel { get; } = typeof(ModifyGuildRoleParams);
    public Type ChannelFollowerResponse { get; } = typeof(Models.Json.FollowedChannel);
    public Type CommandPermissionsResponse { get; } = typeof(GuildApplicationCommandPermission);
    public Type CreateApplicationEmojiRequestModel { get; }
    public Type CreateAutoModerationRule200ResponseModel { get; }
    public Type CreateAutoModerationRuleRequestModel { get; }
    public Type CreateChannelInvite200ResponseModel { get; }
    public Type CreateChannelInviteRequestModel { get; }
    public Type CreateDm200ResponseModel { get; }
    public Type CreatedThreadResponse { get; }
    public Type CreateEntitlementRequestData { get; }
    public Type CreateGuildChannelRequest { get; }
    public Type CreateGuildEmojiRequestModel { get; }
    public Type CreateGuildFromTemplateRequestModel { get; }
    public Type CreateGuildRoleRequestModel { get; }
    public Type CreateGuildScheduledEvent200ResponseModel { get; }
    public Type CreateGuildScheduledEventRequestModel { get; }
    public Type CreateGuildTemplateRequestModel { get; }
    public Type CreateInteractionResponseRequestModel { get; }
    public Type CreatePrivateChannelRequest { get; }
    public Type CreateStageInstanceRequestModel { get; }
    public Type CreateTextThreadWithMessageRequest { get; }
    public Type CreateThreadRequestModel { get; }
    public Type CreateWebhookRequestModel { get; }
    public Type DeleteChannel200ResponseModel { get; }
    public Type EmojiResponse { get; }
    public Type EntitlementResponse { get; }
    public Type ErrorResponse { get; }
    public Type ExecuteSlackCompatibleWebhook200ResponseModel { get; }
    public Type ExecuteWebhookRequestModel { get; }
    public Type FollowChannelRequestModel { get; }
    public Type GatewayBotResponse { get; }
    public Type GatewayResponse { get; }
    public Type GetApplicationRoleConnectionsMetadata200ResponseModel { get; }
    public Type GetAutoModerationRule200ResponseModel { get; }
    public Type GetChannel200ResponseModel { get; }
    public Type GetEntitlements200ResponseModel { get; }
    public Type GetGuildScheduledEvent200ResponseModel { get; }
    public Type GetGuildWebhooks200ResponseModel { get; }
    public Type GetSoundboardDefaultSounds200ResponseModel { get; }
    public Type GetSticker200ResponseModel { get; }
    public Type GetWebhook200ResponseModel { get; }
    public Type GetWebhookByToken200ResponseModel { get; }
    public Type GithubWebhook { get; }
    public Type GuildAuditLogResponse { get; }
    public Type GuildBanResponse { get; }
    public Type GuildChannelResponse { get; }
    public Type GuildCreateRequest { get; }
    public Type GuildHomeSettingsResponse { get; }
    public Type GuildIncomingWebhookResponse { get; }
    public Type GuildMemberResponse { get; }
    public Type GuildMFALevelResponse { get; }
    public Type GuildOnboardingResponse { get; }
    public Type GuildPatchRequestPartial { get; }
    public Type GuildPreviewResponse { get; }
    public Type GuildPruneResponse { get; }
    public Type GuildResponse { get; }
    public Type GuildRoleResponse { get; }
    public Type GuildStickerResponse { get; }
    public Type GuildTemplateResponse { get; }
    public Type GuildWelcomeScreenResponse { get; }
    public Type GuildWithCountsResponse { get; }
    public Type IncomingWebhookUpdateRequestPartial { get; }
    public Type InteractionCallbackResponse { get; }
    public Type InviteResolve200ResponseModel { get; }
    public Type InviteRevoke200ResponseModel { get; }
    public Type ListApplicationCommands200ResponseModel { get; }
    public Type ListApplicationEmojisResponse { get; }
    public Type ListAutoModerationRules200ResponseModel { get; }
    public Type ListChannelInvites200ResponseModel { get; }
    public Type ListChannelWebhooks200ResponseModel { get; }
    public Type ListGuildApplicationCommandPermissions200ResponseModel { get; }
    public Type ListGuildApplicationCommands200ResponseModel { get; }
    public Type ListGuildBans200ResponseModel { get; }
    public Type ListGuildChannels200ResponseModel { get; }
    public Type ListGuildEmojis200ResponseModel { get; }
    public Type ListGuildIntegrations200ResponseModel { get; }
    public Type ListGuildInvites200ResponseModel { get; }
    public Type ListGuildMembers200ResponseModel { get; }
    public Type ListGuildRoles200ResponseModel { get; }
    public Type ListGuildScheduledEvents200ResponseModel { get; }
    public Type ListGuildScheduledEventUsers200ResponseModel { get; }
    public Type ListGuildSoundboardSoundsResponse { get; }
    public Type ListGuildStickers200ResponseModel { get; }
    public Type ListGuildTemplates200ResponseModel { get; }
    public Type ListGuildVoiceRegions200ResponseModel { get; }
    public Type ListMessageReactionsByEmoji200ResponseModel { get; }
    public Type ListMessages200ResponseModel { get; }
    public Type ListMyConnections200ResponseModel { get; }
    public Type ListMyGuilds200ResponseModel { get; }
    public Type ListPinnedMessages200ResponseModel { get; }
    public Type ListThreadMembers200ResponseModel { get; }
    public Type ListVoiceRegions200ResponseModel { get; }
    public Type MessageCreateRequest { get; }
    public Type MessageEditRequestPartial { get; }
    public Type MessageResponse { get; }
    public Type OAuth2GetAuthorizationResponse { get; }
    public Type OAuth2GetKeys { get; }
    public Type PollAnswerDetailsResponse { get; }
    public Type PrivateApplicationResponse { get; }
    public Type PrivateGuildMemberResponse { get; }
    public Type PruneGuildRequestModel { get; }
    public Type SearchGuildMembers200ResponseModel { get; }
    public Type SetChannelPermissionOverwriteRequestModel { get; }
    public Type SetGuildApplicationCommandPermissionsRequestModel { get; }
    public Type SetGuildMfaLevelRequestModel { get; }
    public Type SlackWebhook { get; }
    public Type SoundboardCreateRequest { get; }
    public Type SoundboardPatchRequestPartial { get; }
    public Type SoundboardSoundResponse { get; }
    public Type SoundboardSoundSendRequest { get; }
    public Type StageInstanceResponse { get; }
    public Type StickerPackCollectionResponse { get; }
    public Type StickerPackResponse { get; }
    public Type ThreadMemberResponse { get; }
    public Type ThreadResponse { get; }
    public Type ThreadsResponse { get; }
    public Type TypingIndicatorResponse { get; }
    public Type UpdateApplicationEmojiRequestModel { get; }
    public Type UpdateApplicationRoleConnectionsMetadata200ResponseModel { get; }
    public Type UpdateApplicationRoleConnectionsMetadataRequestModel { get; }
    public Type UpdateApplicationUserRoleConnectionRequestModel { get; }
    public Type UpdateAutoModerationRule200ResponseModel { get; }
    public Type UpdateAutoModerationRuleRequestModel { get; }
    public Type UpdateChannel200ResponseModel { get; }
    public Type UpdateChannelRequestModel { get; }
    public Type UpdateGuildEmojiRequestModel { get; }
    public Type UpdateGuildMemberRequestModel { get; }
    public Type UpdateGuildOnboardingRequest { get; }
    public Type UpdateGuildRoleRequestModel { get; }
    public Type UpdateGuildScheduledEvent200ResponseModel { get; }
    public Type UpdateGuildScheduledEventRequestModel { get; }
    public Type UpdateGuildStickerRequestModel { get; }
    public Type UpdateGuildTemplateRequestModel { get; }
    public Type UpdateGuildWidgetSettingsRequestModel { get; }
    public Type UpdateMyGuildMemberRequestModel { get; }
    public Type UpdateSelfVoiceStateRequestModel { get; }
    public Type UpdateStageInstanceRequestModel { get; }
    public Type UpdateVoiceStateRequestModel { get; }
    public Type UpdateWebhook200ResponseModel { get; }
    public Type UpdateWebhookByToken200ResponseModel { get; }
    public Type UpdateWebhookByTokenRequestModel { get; }
    public Type UpdateWebhookRequestModel { get; }
    public Type UserGuildOnboardingResponse { get; }
    public Type UserPIIResponse { get; }
    public Type UserResponse { get; }
    public Type VanityURLResponse { get; }
    public Type VoiceStateResponse { get; }
    public Type WelcomeScreenPatchRequestPartial { get; }
    public Type WidgetResponse { get; }
    public Type WidgetSettingsResponse { get; }
}