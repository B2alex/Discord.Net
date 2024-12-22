using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Discord.Net.Hanz.Tasks.V2.Nodes;

public interface IJsonPropertyProcessorNode
{
    void Process(ref PropertyDeclarationSyntax syntax, JsonModel model, JsonProperty property);
}