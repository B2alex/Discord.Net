using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace Discord.Net.Hanz.Tasks.ApiRoutes;

public class ApiRouteGenerator : GenerationTask
{
    private static readonly OpenApiStringReader _reader = new();
    
    public IncrementalValuesProvider<OpenApiDocument> OpenApiDocumentsProvider { get; }
    public IncrementalKeyValueProvider<string, OpenApiPathItem> PathsProvider { get; }
    
    public ApiRouteGenerator(IncrementalGeneratorInitializationContext context, ILogger logger) : base(context, logger)
    {
        OpenApiDocumentsProvider = context
            .AdditionalTextsProvider
            .Select(ReadOpenApiSpec)
            .WhereNotNull();

        PathsProvider = OpenApiDocumentsProvider
            .SelectMany((x, _) => x.Paths)
            .ToKeyed(x => (x.Key, x.Value));

        // context.RegisterSourceOutput(
        //     provider,
        //     (_, _) => { }
        // );
    }

    private OpenApiDocument? ReadOpenApiSpec(AdditionalText text, CancellationToken token)
    {
        if (text.GetText(token) is not { } openApiSpec)
        {
            Logger.Warn("Unable to read open API spec.");
            
            return null;
        }

        
        var document =  _reader.Read(openApiSpec.ToString(), out var diagnostic);

        foreach (var error in diagnostic.Errors)
        {
            Logger.Log(LogLevel.Error, $"{error.Message} : {error.Pointer}");
        }

        foreach (var warning in diagnostic.Warnings)
        {
            Logger.Log(LogLevel.Warning, $"{warning.Message} : {warning.Pointer}");
        }
        
        Logger.Log($"Document routes: {document.Paths.Count}");
        
        foreach (var documentPath in document.Paths)
            Logger.Log($" - {documentPath.Key}");

        return document;
    }
}