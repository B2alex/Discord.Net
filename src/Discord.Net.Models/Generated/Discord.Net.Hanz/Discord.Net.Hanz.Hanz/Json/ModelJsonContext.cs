using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using Discord.Models;
using Discord.Models.Json;

namespace Discord.Models;

[System.Text.Json.Serialization.JsonSourceGenerationOptions(
    PropertyNameCaseInsensitive = false,
    IgnoreReadOnlyProperties = true,
    Converters = [
        typeof(Discord.Converters.SnowflakeConverter),
        typeof(Discord.Converters.BigIntegerConverter),
        typeof(Discord.Converters.UserConverter),
        typeof(Discord.Converters.GatewayPayloadConverter),
        typeof(Discord.Converters.MillisecondEpocConverter),
        typeof(Discord.Converters.ReactionIdConverter),
        typeof(Discord.Converters.ExtendedApplicationCommandPermissionUpdatedConverter),
        typeof(Discord.Converters.ExtendedAutoModerationRulePayloadConverter),
        typeof(Discord.Converters.ExtendedChannelPayloadConverter),
        typeof(Discord.Converters.ExtendedEntitlementPayloadConverter),
        typeof(Discord.Converters.ExtendedGuildAuditLogEntryCreatedConverter),
        typeof(Discord.Converters.GuildCreatedUnionConverter_Unavailable),
        typeof(Discord.Converters.ExtendedGuildMemberAddedConverter),
        typeof(Discord.Converters.ExtendedGuildScheduledEventPayloadConverter),
        typeof(Discord.Converters.ExtendedGuildUpdatedConverter),
        typeof(Discord.Converters.ExtendedIntegrationCreatedUpdatedConverter),
        typeof(Discord.Converters.ExtendedInteractionCreatedConverter),
        typeof(Discord.Converters.ExtendedMessageCreatedUpdatedConverter),
        typeof(Discord.Converters.ExtendedPresenceUpdatedConverter),
        typeof(Discord.Converters.ExtendedStageInstancePayloadConverter),
        typeof(Discord.Converters.ExtendedThreadCreatedConverter),
        typeof(Discord.Converters.ExtendedThreadMemberUpdatedConverter),
        typeof(Discord.Converters.ExtendedUserUpdatedConverter),
        typeof(Discord.Converters.ExtendedVoiceStateUpdatedConverter),
        typeof(Discord.Converters.ExtendedExtendedGuildConverter),
        typeof(Discord.Converters.ExtendedMentionedUserConverter),
        typeof(Discord.Converters.ExtendedHeartbeatPayloadDataConverter),
        typeof(Discord.Converters.ExtendedInvalidSessionPayloadDataConverter),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialApplicationModel, Discord.Models.Json.PartialApplication>),
        typeof(Discord.Converters.ApplicationCommandUnionConverter_Type),
        typeof(Discord.Converters.ApplicationCommandOptionUnionConverter_Type),
        typeof(Discord.Converters.AutoModerationActionUnionConverter),
        typeof(Discord.Converters.AutoModerationRuleUnionConverter),
        typeof(Discord.Converters.ChannelUnionConverter_Type),
        typeof(Discord.Converters.ThreadChannelBaseUnionConverter_Type),
        typeof(Discord.Converters.GuildChannelBaseUnionConverter_Type),
        typeof(Discord.Converters.ThreadableChannelBaseUnionConverter_Type),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialCustomEmoteModel, Discord.Models.Json.PartialCustomEmote>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialEmoteModel, Discord.Models.Json.PartialCustomEmote>),
        typeof(Discord.Converters.EmoteUnionConverter_Id),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialEmoteModel, Discord.Models.Json.PartialEmote>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialMemberModel, Discord.Models.Json.PartialGuildMember>),
        typeof(Discord.Converters.InteractionUnionConverter),
        typeof(Discord.Converters.SoundboardSoundUnionConverter_GuildId),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialUserModel, Discord.Models.Json.PartialUser>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialVoiceStateModel, Discord.Models.Json.PartialVoiceState>),
        typeof(Discord.Converters.WebhookUnionConverter_Type),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandPermissionUpdatedPayloadData, Discord.Models.Json.ApplicationCommandPermissionUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildApplicationCommandPermissionsModel, Discord.Models.Json.GuildApplicationCommandPermission>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAutoModerationRulePayloadData, Discord.Models.Json.AutoModerationRulePayload>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAutoModerationRuleModel, Discord.Models.Json.AutoModerationRule>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IChannelPayloadData, Discord.Models.Json.ChannelPayload>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IChannelModel, Discord.Models.Json.Channel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IEntitlementPayloadData, Discord.Models.Json.EntitlementPayload>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IEntitlementModel, Discord.Models.Json.Entitlement>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAuditLogEntryPayloadData, Discord.Models.Json.GuildAuditLogEntryCreated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAuditLogEntryModel, Discord.Models.Json.AuditLogEntry>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildCreatePayloadData, Discord.Models.Json.GuildCreated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildMemberAddedPayloadData, Discord.Models.Json.GuildMemberAdded>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMemberModel, Discord.Models.Json.GuildMember>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildScheduledEventPayloadData, Discord.Models.Json.GuildScheduledEventPayload>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildScheduledEventModel, Discord.Models.Json.GuildScheduledEvent>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildUpdatedPayloadData, Discord.Models.Json.GuildUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildModel, Discord.Models.Json.Guild>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPartialGuildModel, Discord.Models.Json.PartialGuild>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IIntegrationCreateUpdatePayloadData, Discord.Models.Json.IntegrationCreatedUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IIntegrationModel, Discord.Models.Json.Integration>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInteractionCreatedPayloadData, Discord.Models.Json.InteractionCreated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInteractionModel, Discord.Models.Json.Interaction>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMessageCreateUpdatePayloadData, Discord.Models.Json.MessageCreatedUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMessageModel, Discord.Models.Json.Message>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPresenceUpdatedPayloadData, Discord.Models.Json.PresenceUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPresenceModel, Discord.Models.Json.Presence>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStageInstancePayloadData, Discord.Models.Json.StageInstancePayload>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStageInstanceModel, Discord.Models.Json.StageInstance>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IThreadCreatedPayloadData, Discord.Models.Json.ThreadCreated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IThreadChannelModel, Discord.Models.Json.ThreadChannelBase>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildChannelModel, Discord.Models.Json.GuildChannelBase>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IUserUpdatedPayloadData, Discord.Models.Json.UserUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ISelfUserModel, Discord.Models.Json.SelfUser>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IUserModel, Discord.Models.Json.User>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IVoiceStateUpdatedPayloadData, Discord.Models.Json.VoiceStateUpdated>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IVoiceStateModel, Discord.Models.Json.VoiceState>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IExtendedGuild, Discord.Models.Json.ExtendedGuild>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGatewayMessage, Discord.Models.Json.GatewayMessage>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMentionedUser, Discord.Models.Json.MentionedUser>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IUnavailableGuild, Discord.Models.Json.UnavailableGuild>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IActivityModel, Discord.Models.Json.Activity>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationModel, Discord.Models.Json.Application>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationRoleConnectionMetadataModel, Discord.Models.Json.ApplicationRoleConnectionMetadata>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandModel, Discord.Models.Json.ApplicationCommand>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandPermission, Discord.Models.Json.ApplicationCommandPermissions>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandOptionModel, Discord.Models.Json.ApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandOptionChoiceModel<long>, Discord.Models.Json.ApplicationCommandOptionChoice<long>>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandOptionChoiceModel, Discord.Models.Json.ApplicationCommandOptionChoice<long>>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandOptionChoiceModel<string>, Discord.Models.Json.ApplicationCommandOptionChoice<string>>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IApplicationCommandOptionChoiceModel<double>, Discord.Models.Json.ApplicationCommandOptionChoice<double>>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAttachmentApplicationCommandOptionModel, Discord.Models.Json.AttachmentApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IBooleanApplicationCommandOptionModel, Discord.Models.Json.BooleanApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IChannelApplicationCommandOptionModel, Discord.Models.Json.ChannelApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IIntegerApplicationCommandOptionModel, Discord.Models.Json.IntegerApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMentionableApplicationCommandOptionModel, Discord.Models.Json.MentionableApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.INumberApplicationCommandOptionModel, Discord.Models.Json.NumberApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IRoleApplicationCommandOptionModel, Discord.Models.Json.RoleApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStringApplicationCommandOptionModel, Discord.Models.Json.StringApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ISubCommandApplicationCommandOptionModel, Discord.Models.Json.SubCommandApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ISubCommandGroupApplicationCommandOptionModel, Discord.Models.Json.SubCommandGroupApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IUserApplicationCommandOptionModel, Discord.Models.Json.UserApplicationCommandOption>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IChatInputApplicationCommandModel, Discord.Models.Json.ChatInputApplicationCommand>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPrimaryEntryPointApplicationCommandModel, Discord.Models.Json.PrimaryEntryPointApplicationCommand>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ISkuModel, Discord.Models.Json.Sku>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IDMChannelModel, Discord.Models.Json.DMChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ITagModel, Discord.Models.Json.ForumTag>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGroupDMChannelModel, Discord.Models.Json.GroupDMChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildNewsChannelModel, Discord.Models.Json.GuildAnnouncementChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildTextChannelModel, Discord.Models.Json.GuildTextChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IThreadableChannelModel, Discord.Models.Json.ThreadableChannelBase>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildCategoryChannelModel, Discord.Models.Json.GuildCategoryChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildDirectoryChannelModel, Discord.Models.Json.GuildDirectoryChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildForumChannelModel, Discord.Models.Json.GuildForumChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildMediaChannelModel, Discord.Models.Json.GuildMediaChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildStageChannelModel, Discord.Models.Json.GuildStageChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildVoiceChannelModel, Discord.Models.Json.GuildVoiceChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAudioChannelModel, Discord.Models.Json.GuildVoiceChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IThreadMemberModel, Discord.Models.Json.ThreadMember>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ICustomEmoteModel, Discord.Models.Json.CustomEmote>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IEmoteModel, Discord.Models.Json.Emote>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IEmojiModel, Discord.Models.Json.Emoji>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IBanModel, Discord.Models.Json.Ban>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IOverwriteModel, Discord.Models.Json.Overwrite>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IRoleModel, Discord.Models.Json.Role>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildTemplateModel, Discord.Models.Json.GuildTemplate>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IIntegrationAccountModel, Discord.Models.Json.IntegrationAccount>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInteractionCallbackModel, Discord.Models.Json.InteractionCallback>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IActivityInstanceModel, Discord.Models.Json.InteractionCallbackActivityInstance>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInteractionCallbackResourceModel, Discord.Models.Json.InteractionCallbackResource>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInteractionCallbackResponseModel, Discord.Models.Json.InteractionCallbackResponse>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IInviteModel, Discord.Models.Json.Invite>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IAttachmentModel, Discord.Models.Json.Attachment>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMessageInteractionMetadataModel, Discord.Models.Json.MessageInteractionMetadata>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IMentionedChannelModel, Discord.Models.Json.MessageMentionedChannel>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPollModel, Discord.Models.Json.Poll>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPollAnswerModel, Discord.Models.Json.PollAnswer>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPollAnswerCountModel, Discord.Models.Json.PollAnswerCount>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPollMediaModel, Discord.Models.Json.PollMedia>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IPollResultModel, Discord.Models.Json.PollResult>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IReactionModel, Discord.Models.Json.Reaction>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildScheduledEventUserModel, Discord.Models.Json.GuildScheduledEventUser>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildSoundboardSoundModel, Discord.Models.Json.GuildSoundboardSound>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ISoundboardSoundModel, Discord.Models.Json.SoundboardSound>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IGuildStickerModel, Discord.Models.Json.Sticker>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStickerModel, Discord.Models.Json.Sticker>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStickerItemModel, Discord.Models.Json.StickerItem>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IStickerPackModel, Discord.Models.Json.StickerPack>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ITeamModel, Discord.Models.Json.Team>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.ITeamMember, Discord.Models.Json.TeamMember>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IUserConnectionModel, Discord.Models.Json.UserConnection>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IVoiceRegionModel, Discord.Models.Json.VoiceRegion>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IChannelFollowerWebhookModel, Discord.Models.Json.ChannelFollowerWebhook>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IWebhookModel, Discord.Models.Json.Webhook>),
        typeof(Discord.Converters.ModelInterfaceConverter<Discord.Models.IIncomingWebhookModel, Discord.Models.Json.IncomingWebhook>),
        typeof(Discord.Converters.OptionalConverter<ulong>),
        typeof(Discord.Converters.OptionalConverter<string>),
        typeof(Discord.Converters.OptionalConverter<System.DateTimeOffset?>),
        typeof(Discord.Converters.OptionalConverter<string?>),
        typeof(Discord.Converters.OptionalConverter<bool>),
        typeof(Discord.Converters.OptionalConverter<int>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.AvatarDecorationData?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.User>),
        typeof(Discord.Converters.OptionalConverter<PartialApplication>),
        typeof(Discord.Converters.OptionalConverter<PartialGuildMember>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.GuildMember>),
        typeof(Discord.Converters.OptionalConverter<string[]>),
        typeof(Discord.Converters.OptionalConverter<ulong[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ThreadMember[]>),
        typeof(Discord.Converters.OptionalConverter<int?>),
        typeof(Discord.Converters.OptionalConverter<int[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.PresenceUpdatePayloadData>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActivityTimestamps>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.IEmojiModel?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActivityParty>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActivityAssets>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActivitySecrets>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActivityButton[]>),
        typeof(Discord.Converters.OptionalConverter<long[]>),
        typeof(Discord.Converters.OptionalConverter<System.DateTimeOffset>),
        typeof(Discord.Converters.OptionalConverter<object>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationCommandInteractionInteractionDataOption[]>),
        typeof(Discord.Converters.OptionalConverter<PartialUser>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.PartialGuild>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InstallParams>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationIntegrationTypesConfig>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationIntegrationTypeConfiguration>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.IDictionary<string, string>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, string>>),
        typeof(Discord.Converters.OptionalConverter<int[]?>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, string>?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationCommandOptionChoice<long>[]>),
        typeof(Discord.Converters.OptionalConverter<long>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationCommandOptionChoice<double>[]>),
        typeof(Discord.Converters.OptionalConverter<double>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationCommandOptionChoice<string>[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ApplicationCommandOption[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.AuditLogChange[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.AuditLogOptions>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ActionMetadata>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.TriggerMetadata?>),
        typeof(Discord.Converters.OptionalConverter<ulong?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Embed[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.AllowedMentions>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageComponent[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Overwrite[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ForumTag[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.DefaultReactionModel>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ThreadMember>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Sticker[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.WelcomeScreen>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.RoleTags>),
        typeof(Discord.Converters.OptionalConverter<bool?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.IntegrationAccount>),
        typeof(Discord.Converters.OptionalConverter<Discord.DiscordEmojiId>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.SelectMenuOption[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.SelectMenuDefaultValueModel[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InteractionDataResolved>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.User>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.GuildMember>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.Role>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.Channel>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.Message>>),
        typeof(Discord.Converters.OptionalConverter<System.Collections.Generic.Dictionary<string, Discord.Models.Json.Attachment>>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InteractionData>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Channel>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Message>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.IApplicationCommandOptionChoiceModel[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InteractionCallbackActivityInstance>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InteractionCallbackResource>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.InteractionCallbackData>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Application>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.GuildScheduledEvent>),
        typeof(Discord.Converters.OptionalConverter<float>),
        typeof(Discord.Converters.OptionalConverter<uint>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedAuthor>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedFooter>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedVideo>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedThumbnail>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedImage>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedProvider>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.EmbedField[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageMentionedChannel[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Reaction[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Attachment[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageActivity>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageApplication>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageReference>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Message?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageInteractionMetadata>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ThreadChannelBase>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.StickerItem[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.MessageRoleSubscriptionData>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Poll>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.PollResult>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ClientStatus>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Activity[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Integration[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.WebhookSourceChannel>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.IApplicationCommandOptionModel[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.TriggerMetadata>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.AutoModerationAction[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Overwrite[]?>),
        typeof(Discord.Converters.OptionalConverter<Discord.DiscordEmojiId?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.ForumTag[]?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.Role[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.CreateGuildChannelParams[]>),
        typeof(Discord.Converters.OptionalConverter<ulong[]?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.WelcomeScreenChannel[]>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.GuildScheduledEventEntityMetadata>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.GuildScheduledEventEntityMetadata?>),
        typeof(Discord.Converters.OptionalConverter<Discord.Models.Json.CreatePollParams>),
        typeof(Discord.Converters.OptionalConverter<double?>)]
)]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AllReactionsRemoved))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AllReactionsRemoved>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandPermissionUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandPermissionUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AutoModerationActionExecuted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AutoModerationActionExecuted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AutoModerationRulePayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AutoModerationRulePayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BulkMessageDeleted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BulkMessageDeleted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChannelPayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChannelPayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChannelPinsUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChannelPinsUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EntitlementPayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EntitlementPayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildAuditLogEntryCreated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildAuditLogEntryCreated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildBanPayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildBanPayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildCreated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildCreated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildEmotesUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildEmotesUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildIntegrationsUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildIntegrationsUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMemberAdded))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildMemberAdded>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMemberRemoved))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildMemberRemoved>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMemberUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildMemberUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildRoleCreatedUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildRoleCreatedUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildRoleDeleted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildRoleDeleted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEventPayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildScheduledEventPayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEventUserPayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildScheduledEventUserPayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildStickersUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildStickersUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IntegrationCreatedUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IntegrationCreatedUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IntegrationDeleted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IntegrationDeleted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCreated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCreated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InviteCreated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InviteCreated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InviteDeleted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InviteDeleted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageCreatedUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageCreatedUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageDeleted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageDeleted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessagePollVotePayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessagePollVotePayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PresenceUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PresenceUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReactionAdded))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReactionAdded>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReactionRemoved))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReactionRemoved>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReactionRemovedEmoji))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReactionRemovedEmoji>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StageInstancePayload))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StageInstancePayload>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadCreated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadCreated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadListSynced))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadListSynced>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMembersUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadMembersUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMemberUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadMemberUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.TypingStarted))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.TypingStarted>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UserUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UserUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.VoiceServerUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.VoiceServerUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.VoiceStateUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.VoiceStateUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WebhookUpdated))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.WebhookUpdated>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ExtendedGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ExtendedGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GatewayMessage))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GatewayMessage>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MentionedUser))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MentionedUser>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.HeartbeatPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.HeartbeatPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.HelloPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.HelloPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IdentityPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IdentityPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IdentityConnectionProperties))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IdentityConnectionProperties>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InvalidSessionPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InvalidSessionPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PresenceUpdatePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PresenceUpdatePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReadyPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReadyPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.RequestGuildMembersPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.RequestGuildMembersPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ResumePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ResumePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UpdateVoiceStatePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UpdateVoiceStatePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UnavailableGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UnavailableGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Activity))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Activity>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityAssets))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActivityAssets>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityButton))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActivityButton>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityParty))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActivityParty>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivitySecrets))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActivitySecrets>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityTimestamps))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActivityTimestamps>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandInteractionInteractionDataOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandInteractionInteractionDataOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Application))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Application>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialApplicationModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialApplicationModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialApplication))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialApplication>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationIntegrationTypeConfiguration))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationIntegrationTypeConfiguration>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationIntegrationTypesConfig))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationIntegrationTypesConfig>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationRoleConnection))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationRoleConnection>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationRoleConnectionMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationRoleConnectionMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommand))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommand>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandPermissions))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandPermissions>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildApplicationCommandPermission))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildApplicationCommandPermission>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<long>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandOptionChoice<long>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<string>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandOptionChoice<string>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<double>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandOptionChoice<double>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AttachmentApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AttachmentApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BooleanApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BooleanApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChannelApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChannelApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IntegerApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IntegerApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MentionableApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MentionableApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.NumberApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.NumberApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.RoleApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.RoleApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StringApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StringApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SubCommandApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SubCommandApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SubCommandGroupApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SubCommandGroupApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UserApplicationCommandOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UserApplicationCommandOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChatInputApplicationCommand))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChatInputApplicationCommand>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PrimaryEntryPointApplicationCommand))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PrimaryEntryPointApplicationCommand>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InstallParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InstallParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Sku))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Sku>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Entitlement))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Entitlement>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLog))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AuditLog>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLogChange))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AuditLogChange>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLogEntry))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AuditLogEntry>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLogOptions))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AuditLogOptions>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BlockMessageMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BlockMessageMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SendAlertMessageMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SendAlertMessageMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.TimeoutMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.TimeoutMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AutoModerationAction))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AutoModerationAction>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AutoModerationRule))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AutoModerationRule>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.KeywordPresetTriggerMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.KeywordPresetTriggerMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.KeywordTriggerMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.KeywordTriggerMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MemberProfileTriggerMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MemberProfileTriggerMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MentionSpamTriggerMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MentionSpamTriggerMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AnnouncementThreadChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AnnouncementThreadChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Channel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Channel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChannelThreads))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChannelThreads>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.DefaultReactionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.DefaultReactionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.DMChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.DMChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.FollowedChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.FollowedChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ForumReactionEmoji))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ForumReactionEmoji>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ForumTag))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ForumTag>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ForumOrMediaThreadMessage))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ForumOrMediaThreadMessage>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GroupDMChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GroupDMChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildAnnouncementChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildAnnouncementChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildCategoryChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildCategoryChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildChannelBase))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildChannelBase>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildDirectoryChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildDirectoryChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildForumChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildForumChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMediaChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildMediaChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildStageChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildStageChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildTextChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildTextChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildVoiceChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildVoiceChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PrivateThreadChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PrivateThreadChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PublicThreadChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PublicThreadChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadableChannelBase))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadableChannelBase>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadChannelBase))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadChannelBase>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMember))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadMember>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ThreadMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CustomEmote))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CustomEmote>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialCustomEmoteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialCustomEmoteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialEmoteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialEmoteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialCustomEmote))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialCustomEmote>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Emoji))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Emoji>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Emote))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Emote>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialEmote))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialEmote>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Error))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Error>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GetGatewayBotResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GetGatewayBotResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GetGatewayResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GetGatewayResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Ban))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Ban>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BulkBanResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BulkBanResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Guild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Guild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMember))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildMember>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialMemberModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialMemberModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialGuildMember))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialGuildMember>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildOnboardings))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildOnboardings>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildOnboardingPrompt))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildOnboardingPrompt>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildOnboardingPromptOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildOnboardingPromptOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildPreview))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildPreview>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildPruneCount))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildPruneCount>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildWidget))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildWidget>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildWidgetSettings))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildWidgetSettings>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InviteVanity))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InviteVanity>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ListActiveGuildThreadsResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ListActiveGuildThreadsResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MfaLevelResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MfaLevelResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Overwrite))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Overwrite>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Role))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Role>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.RoleTags))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.RoleTags>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StageInstance))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StageInstance>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildTemplate))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildTemplate>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WelcomeScreen))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.WelcomeScreen>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WelcomeScreenChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.WelcomeScreenChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Integration))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Integration>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IntegrationAccount))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IntegrationAccount>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationIntegrationTypes))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationIntegrationTypes>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActionRow))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ActionRow>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ButtonComponent))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ButtonComponent>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageComponent))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageComponent>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelectMenuComponent))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SelectMenuComponent>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelectMenuDefaultValueModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SelectMenuDefaultValueModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelectMenuOption))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SelectMenuOption>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.TextInputComponent))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.TextInputComponent>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandInteractionData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ApplicationCommandInteractionData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionDataResolved))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionDataResolved>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageComponentData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageComponentData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModalSubmitData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModalSubmitData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Interaction))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Interaction>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallback))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCallback>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackActivityInstance))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCallbackActivityInstance>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCallbackData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackResource))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCallbackResource>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionCallbackResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionResponse))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InteractionResponse>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Invite))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Invite>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InviteMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.InviteMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AllowedMentions))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AllowedMentions>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Attachment))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Attachment>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.DefaultReaction))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.DefaultReaction>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Embed))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Embed>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedAuthor))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedAuthor>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedField))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedField>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedFooter))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedFooter>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedImage))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedImage>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedProvider))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedProvider>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedThumbnail))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedThumbnail>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedVideo))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.EmbedVideo>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Message))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Message>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageActivity))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageActivity>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageApplication))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageApplication>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageInteractionMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageInteractionMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageMentionedChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageMentionedChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageReference))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageReference>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageRoleSubscriptionData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.MessageRoleSubscriptionData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Poll))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Poll>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollAnswer))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PollAnswer>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollAnswerCount))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PollAnswerCount>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollMedia))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PollMedia>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollResult))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PollResult>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollVoters))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PollVoters>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Reaction))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Reaction>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReactionCountDetails))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReactionCountDetails>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ClientStatus))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ClientStatus>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Presence))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Presence>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Ratelimit))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Ratelimit>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ReadState))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ReadState>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEvent))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildScheduledEvent>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEventEntityMetadata))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildScheduledEventEntityMetadata>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEventUser))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildScheduledEventUser>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SessionStartLimit))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SessionStartLimit>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildSoundboardSound))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GuildSoundboardSound>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SoundboardSound))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SoundboardSound>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.NitroStickerPacks))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.NitroStickerPacks>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Sticker))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Sticker>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StickerItem))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StickerItem>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StickerPack))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StickerPack>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AvatarDecorationData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AvatarDecorationData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelfUser))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.SelfUser>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Team))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Team>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.TeamMember))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.TeamMember>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.User))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.User>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialUserModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialUserModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialUser))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialUser>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UserConnection))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UserConnection>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.UserGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.UserGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.VoiceState))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.VoiceState>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialVoiceStateModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialVoiceStateModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialVoiceState))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.PartialVoiceState>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.VoiceRegion))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.VoiceRegion>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ChannelFollowerWebhook))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ChannelFollowerWebhook>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IncomingWebhook))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.IncomingWebhook>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WebhookSourceChannel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.WebhookSourceChannel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Webhook))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.Webhook>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGlobalApplicationCommandParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGlobalApplicationCommandParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildApplicationCommandParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildApplicationCommandParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyApplicationCommandPermissionsParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyApplicationCommandPermissionsParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGlobalApplicationCommandParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGlobalApplicationCommandParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildApplicationCommandParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildApplicationCommandParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyCurrentApplicationParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyCurrentApplicationParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateTestEntitlementParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateTestEntitlementParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BulkDeleteMessagesParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BulkDeleteMessagesParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateDMChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateDMChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGroupDMChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGroupDMChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.FollowAnnouncementChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.FollowAnnouncementChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GroupDmAddRecipientParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.GroupDmAddRecipientParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyChannelPermissionsParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyChannelPermissionsParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGroupDmParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGroupDmParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyThreadChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyThreadChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StartThreadFromMessageParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StartThreadFromMessageParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StartThreadInForumOrMediaParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StartThreadInForumOrMediaParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StartThreadParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.StartThreadParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateAutoModRuleParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateAutoModRuleParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyAutoModRuleParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyAutoModRuleParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BeginGuildPruneParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BeginGuildPruneParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.BulkBanUsersParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.BulkBanUsersParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildBanParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildBanParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildChannelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildChannelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildChannelPositionsParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildChannelPositionsParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateApplicationEmojiParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateApplicationEmojiParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildEmojiParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildEmojiParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyApplicationEmojiParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyApplicationEmojiParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyEmojiParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyEmojiParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AddGuildMemberParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.AddGuildMemberParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyCurrentMemberParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyCurrentMemberParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildMemberParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildMemberParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildMfaLevelParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildMfaLevelParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildWelcomeScreenParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildWelcomeScreenParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildWidgetParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildWidgetParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildRoleParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildRoleParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildRoleParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildRoleParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildRolePositionParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildRolePositionParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildScheduledEventParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildScheduledEventParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildScheduledEventParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildScheduledEventParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildStickerParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildStickerParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildFromTemplateParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateGuildFromTemplateParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateTemplateParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateTemplateParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyGuildTemplateParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyGuildTemplateParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateChannelInviteParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateChannelInviteParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateMessageParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateMessageParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyMessageParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyMessageParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreatePollParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreatePollParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.CreateGuildSoundboardSoundParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.CreateGuildSoundboardSoundParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ModifyGuildSoundboardSoundParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ModifyGuildSoundboardSoundParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.SendSoundboardSoundParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.SendSoundboardSoundParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.CreateStageInstanceParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.CreateStageInstanceParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ModifyStageInstanceParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ModifyStageInstanceParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyCurrentUserParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyCurrentUserParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyUserRoleConnectionParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyUserRoleConnectionParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyCurrentUserVoiceStateParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyCurrentUserVoiceStateParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyUserVoiceStateParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyUserVoiceStateParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateWebhookParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.CreateWebhookParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ExecuteWebhookParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ExecuteWebhookParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyWebhookMessageParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyWebhookMessageParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyWebhookParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyWebhookParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ModifyWebhookWithTokenParams))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.Json.ModifyWebhookWithTokenParams>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandPermissionUpdatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandPermissionUpdatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildApplicationCommandPermissionsModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildApplicationCommandPermissionsModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAutoModerationRulePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAutoModerationRulePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAutoModerationRuleModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAutoModerationRuleModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IChannelPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IChannelPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IEntitlementPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IEntitlementPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IEntitlementModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IEntitlementModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAuditLogEntryPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAuditLogEntryPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAuditLogEntryModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAuditLogEntryModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildCreatePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildCreatePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildMemberAddedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildMemberAddedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMemberModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMemberModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildScheduledEventPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildScheduledEventPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildScheduledEventModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildScheduledEventModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildUpdatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildUpdatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPartialGuildModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPartialGuildModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IIntegrationCreateUpdatePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IIntegrationCreateUpdatePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IIntegrationModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IIntegrationModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInteractionCreatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInteractionCreatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInteractionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInteractionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMessageCreateUpdatePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMessageCreateUpdatePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMessageModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMessageModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPresenceUpdatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPresenceUpdatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPresenceModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPresenceModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStageInstancePayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStageInstancePayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStageInstanceModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStageInstanceModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IThreadCreatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IThreadCreatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IThreadChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IThreadChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IUserUpdatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IUserUpdatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ISelfUserModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ISelfUserModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IUserModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IUserModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IVoiceStateUpdatedPayloadData))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IVoiceStateUpdatedPayloadData>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IVoiceStateModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IVoiceStateModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IExtendedGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IExtendedGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGatewayMessage))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGatewayMessage>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMentionedUser))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMentionedUser>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IUnavailableGuild))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IUnavailableGuild>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IActivityModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IActivityModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationRoleConnectionMetadataModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationRoleConnectionMetadataModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandPermission))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandPermission>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionChoiceModel<long>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandOptionChoiceModel<long>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionChoiceModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandOptionChoiceModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionChoiceModel<string>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandOptionChoiceModel<string>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionChoiceModel<double>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IApplicationCommandOptionChoiceModel<double>>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAttachmentApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAttachmentApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IBooleanApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IBooleanApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IChannelApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IChannelApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IIntegerApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IIntegerApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMentionableApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMentionableApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.INumberApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.INumberApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IRoleApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IRoleApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStringApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStringApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ISubCommandApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ISubCommandApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ISubCommandGroupApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ISubCommandGroupApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IUserApplicationCommandOptionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IUserApplicationCommandOptionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IChatInputApplicationCommandModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IChatInputApplicationCommandModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPrimaryEntryPointApplicationCommandModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPrimaryEntryPointApplicationCommandModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ISkuModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ISkuModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IDMChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IDMChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ITagModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ITagModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGroupDMChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGroupDMChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildNewsChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildNewsChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildTextChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildTextChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IThreadableChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IThreadableChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildCategoryChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildCategoryChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildDirectoryChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildDirectoryChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildForumChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildForumChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildMediaChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildMediaChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildStageChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildStageChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildVoiceChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildVoiceChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAudioChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAudioChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IThreadMemberModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IThreadMemberModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ICustomEmoteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ICustomEmoteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IEmoteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IEmoteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IEmojiModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IEmojiModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IBanModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IBanModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IOverwriteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IOverwriteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IRoleModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IRoleModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildTemplateModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildTemplateModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IIntegrationAccountModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IIntegrationAccountModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInteractionCallbackModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInteractionCallbackModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IActivityInstanceModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IActivityInstanceModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInteractionCallbackResourceModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInteractionCallbackResourceModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInteractionCallbackResponseModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInteractionCallbackResponseModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IInviteModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IInviteModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IAttachmentModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IAttachmentModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMessageInteractionMetadataModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMessageInteractionMetadataModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IMentionedChannelModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IMentionedChannelModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPollModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPollModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPollAnswerModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPollAnswerModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPollAnswerCountModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPollAnswerCountModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPollMediaModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPollMediaModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IPollResultModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IPollResultModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IReactionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IReactionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildScheduledEventUserModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildScheduledEventUserModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildSoundboardSoundModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildSoundboardSoundModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ISoundboardSoundModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ISoundboardSoundModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IGuildStickerModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IGuildStickerModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStickerModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStickerModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStickerItemModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStickerItemModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IStickerPackModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IStickerPackModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ITeamModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ITeamModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.ITeamMember))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.ITeamMember>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IUserConnectionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IUserConnectionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IVoiceRegionModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IVoiceRegionModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IChannelFollowerWebhookModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IChannelFollowerWebhookModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IWebhookModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IWebhookModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IIncomingWebhookModel))]
[System.Text.Json.Serialization.JsonSerializable(typeof(IEnumerable<Discord.Models.IIncomingWebhookModel>))]
[System.Text.Json.Serialization.JsonSerializable(typeof(ulong))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(string))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.DateTimeOffset?))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(bool))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(int))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AvatarDecorationData))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.User))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(PartialApplication))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(PartialGuildMember))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildMember))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(string[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(ulong[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMember[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(int?))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(int[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PresenceUpdatePayloadData))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityTimestamps))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IEmojiModel))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityParty))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityAssets))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivitySecrets))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActivityButton[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(long[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.DateTimeOffset))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(object))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandInteractionInteractionDataOption[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(PartialUser))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PartialGuild))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InstallParams))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationIntegrationTypesConfig))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationIntegrationTypeConfiguration))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.IDictionary<string, string>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, string>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<long>[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(long))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<double>[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(double))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOptionChoice<string>[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ApplicationCommandOption[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLogChange[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AuditLogOptions))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ActionMetadata))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.TriggerMetadata))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(ulong?))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Embed[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AllowedMentions))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageComponent[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Overwrite[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ForumTag[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.DefaultReactionModel))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadMember))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Sticker[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WelcomeScreen))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.RoleTags))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(bool?))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.IntegrationAccount))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.DiscordEmojiId))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelectMenuOption[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.SelectMenuDefaultValueModel[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionDataResolved))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.User>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.GuildMember>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.Role>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.Channel>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.Message>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(System.Collections.Generic.Dictionary<string, Discord.Models.Json.Attachment>))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionData))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Channel))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Message))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionChoiceModel[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackActivityInstance))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackResource))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.InteractionCallbackData))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Application))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEvent))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(float))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(uint))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedAuthor))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedFooter))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedVideo))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedThumbnail))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedImage))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedProvider))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.EmbedField[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageMentionedChannel[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Reaction[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Attachment[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageActivity))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageApplication))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageReference))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageInteractionMetadata))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ThreadChannelBase))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.StickerItem[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.MessageRoleSubscriptionData))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Poll))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.PollResult))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.ClientStatus))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Activity[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Integration[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WebhookSourceChannel))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.IApplicationCommandOptionModel[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.AutoModerationAction[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.DiscordEmojiId?))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.Role[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreateGuildChannelParams[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.WelcomeScreenChannel[]))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.GuildScheduledEventEntityMetadata))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(Discord.Models.Json.CreatePollParams))] // extra from GenerateOptions
[System.Text.Json.Serialization.JsonSerializable(typeof(double?))] // extra from GenerateOptions
public sealed partial class ModelJsonContext : JsonSerializerContext
{
    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.GatewayMessage> CreateGatewayMessageTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.GatewayMessage>
        {
            ObjectCreator = () => new global::Discord.Models.Json.GatewayMessage(),
            ObjectWithParameterizedConstructorCreator = null,
            PropertyMetadataInitializer = _ => GatewayMessagePropInit(options),
            ConstructorParameterMetadataInitializer = null,
            SerializeHandler = GatewayMessageSerializeHandler
        };
        var jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.GatewayMessage>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }

    internal global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Discord.Models.Json.User> CreateUserTypeInfoNoConverter(global::System.Text.Json.JsonSerializerOptions options)
    {
        var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::Discord.Models.Json.User>
        {
            ObjectCreator = null,
            ObjectWithParameterizedConstructorCreator = static args => new global::Discord.Models.Json.User()
            {
                Username = (string)args[0],
                Discriminator = (string)args[1]
            },
            PropertyMetadataInitializer = _ => UserPropInit(options),
            ConstructorParameterMetadataInitializer = UserCtorParamInit,
            SerializeHandler = UserSerializeHandler
        };
        var jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::Discord.Models.Json.User>(options, objectInfo);
        jsonTypeInfo.NumberHandling = null;
        jsonTypeInfo.OriginatingResolver = this;
        return jsonTypeInfo;
    }
}