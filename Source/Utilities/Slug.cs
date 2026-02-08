namespace HttpsRichardy.Internal.Essentials.Utilities;

public static class Slug
{
    public static string Parse(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return string.Empty;

        value = value.ToLowerInvariant();
        value = RemoveDiacritics(value);

        #pragma warning disable SYSLIB1045

        // we intentionally use Regex.Replace here instead of GeneratedRegexAttribute.
        // this approach is more readable, and sufficient for our use case.

        // https://learn.microsoft.com/dotnet/api/system.text.regularexpressions.generatedregexattribute

        value = Regex.Replace(value, @"[^a-z0-9\s-]", "");
        value = Regex.Replace(value, @"\s+", "-");
        value = Regex.Replace(value, @"-+", "-");

        #pragma warning restore SYSLIB1045

        return value.Trim('-');
    }

    private static string RemoveDiacritics(string text)
    {
        var normalized = text.Normalize(NormalizationForm.FormD);
        var builder = new StringBuilder();

        foreach (var character in normalized)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(character);
            if (category != UnicodeCategory.NonSpacingMark)
            {
                builder.Append(character);
            }
        }

        return builder.ToString()
            .Normalize(NormalizationForm.FormC);
    }
}