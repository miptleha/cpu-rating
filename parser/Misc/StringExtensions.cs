using System;
using System.Globalization;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    /// <summary>
    /// Convert string to decimal, returns null if not possible
    /// </summary>
    /// <param name="input">String to convert</param>
    /// <returns>decimal? (decimal or null)</returns>
    public static decimal? ToDecimal(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        input = Regex.Replace(input, @"[^\d.]", "");

        if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
            return result;

        return null;
    }

    /// <summary>
    /// Substring by words
    /// </summary>
    /// <param name="text">Source string</param>
    /// <param name="start">Start index (from 1). If null - from first word</param>
    /// <param name="end">Last index (inclusive). If null - till end</param>
    /// <returns>Substring with selected words (or empty for not valid interval)</returns>
    public static string GetWordsInRange(this string text, int? start = null, int? end = null)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        // split string
        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // check not empty
        if (words.Length == 0)
            return string.Empty;

        // Convert nulls to default values
        int startIndex = (start ?? 1) - 1;
        int endIndex = end.HasValue ? end.Value - 1 : words.Length - 1;

        // Check validity
        if (startIndex < 0 || endIndex >= words.Length || startIndex > endIndex)
            return string.Empty;

        // Select words and concatenate them
        return string.Join(" ", words.Skip(startIndex).Take(endIndex - startIndex + 1));
    }
}