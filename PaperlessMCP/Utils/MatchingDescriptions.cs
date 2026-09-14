namespace PaperlessMCP.Utils;

/// <summary>
/// Shared parameter descriptions exposed in MCP tool metadata.
/// </summary>
internal static class MatchingDescriptions
{
    public const string Pattern =
        "Any/All split words on whitespace; quote phrases. With Any, foobar ltd matches " +
        "either word; \"foobar ltd\" matches the phrase. | means OR only in Regex mode. " +
        "To disable content matching, use match=\"\" and matchingAlgorithm=0.";

    public const string Algorithm =
        "0=None, 1=Any, 2=All, 3=Literal, 4=Regex, 5=Fuzzy, 6=Auto (learned). " +
        "Set explicitly with match when defining or changing a rule.";
}
