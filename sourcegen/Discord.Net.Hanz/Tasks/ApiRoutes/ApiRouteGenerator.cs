using Microsoft.CodeAnalysis;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace Discord.Net.Hanz.Tasks.ApiRoutes;

public class ApiRouteGenerator : GenerationTask
{
    private static readonly OpenApiStringReader _reader = new();
    
    public IncrementalValuesProvider<OpenApiDocument> OpenApiDocumentsProvider { get; }
    public IncrementalKeyValueProvider<string, OpenApiPathItem> PathsProvider { get; }
    
    public ApiRouteGenerator(IncrementalGeneratorInitializationContext context, Logger logger) : base(context, logger)
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
        using var logger = Logger.GetSubLogger(nameof(ReadOpenApiSpec));

        if (text.GetText(token) is not { } openApiSpec)
        {
            logger.Warn("Unable to read open API spec.");
            
            return null;
        }

        
        var document =  _reader.Read(openApiSpec.ToString(), out var diagnostic);

        foreach (var error in diagnostic.Errors)
        {
            logger.Log(LogLevel.Error, $"{error.Message} : {error.Pointer}");
        }

        foreach (var warning in diagnostic.Warnings)
        {
            logger.Log(LogLevel.Warning, $"{warning.Message} : {warning.Pointer}");
        }
        
        logger.Log($"Document routes: {document.Paths.Count}");
        
        foreach (var documentPath in document.Paths)
            logger.Log($" - {documentPath.Key}");

        return document;
    }
}