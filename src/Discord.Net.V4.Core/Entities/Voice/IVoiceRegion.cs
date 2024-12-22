using Discord.Models;

namespace Discord;

public partial interface IVoiceRegion : 
    IEntity<string, IVoiceRegionModel>,
    IVoiceRegionActor
{
    
}