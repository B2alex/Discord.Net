using System.Runtime.CompilerServices;
using Discord.Rest;

namespace Discord.Rest;

public partial interface IRouteMapper
{
    internal static T ResolvePathParameter<T>(IPathable path, PathParameterType type)
    {
        switch(type)
        {
            
            default: break;
        }
        
        
        
        throw new InvalidOperationException("Unable to resolve path parameter.");
    }
    

    internal static virtual bool TryResolvePathParameter<T>(
        IPathable path,
        PathParameterType type,
        out T parameter
    )
    {
        parameter = default!;
        return false;
    }
    
}
