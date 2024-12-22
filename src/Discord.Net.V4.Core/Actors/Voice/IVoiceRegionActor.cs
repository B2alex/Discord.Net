namespace Discord;

[FetchableOfMany<Routes.ListVoiceRegions>]
public partial interface IVoiceRegionActor : 
    IActor<string, IVoiceRegion>;