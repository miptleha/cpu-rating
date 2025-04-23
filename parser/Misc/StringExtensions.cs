using System;
using System.Globalization;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    /// <summary>
    /// Безопасно преобразует строку в decimal. Возвращает null, если преобразование невозможно.
    /// </summary>
    /// <param name="input">Строка для преобразования</param>
    /// <returns>decimal? (число или null)</returns>
    public static decimal? ToDecimal(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return null;

        input = Regex.Replace(input, @"[^\d.]", "");

        // Пробуем инвариантную культуру (например, "123.45" в invariant)
        if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal result))
            return result;

        return null;
    }

    /// <summary>
    /// Возвращает слово (или слова) из строки по указанному интервалу.
    /// </summary>
    /// <param name="text">Исходная строка</param>
    /// <param name="start">Начальный индекс (с 1). Если null — начинаем с первого слова.</param>
    /// <param name="end">Конечный индекс (включительно). Если null — до конца строки.</param>
    /// <returns>Строка с выбранными словами (или пустая строка, если интервал невалиден)</returns>
    public static string GetWordsInRange(this string text, int? start = null, int? end = null)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;

        // Разбиваем строку на слова (игнорируя пустые)
        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Если слова нет — возвращаем пустую строку
        if (words.Length == 0)
            return string.Empty;

        // Нормализуем start и end
        int startIndex = (start ?? 1) - 1; // Если start не указан — берём 1 (преобразуется в 0)
        int endIndex = end.HasValue ? end.Value - 1 : words.Length - 1; // Если end не указан — до конца

        // Проверяем валидность интервала
        if (startIndex < 0 || endIndex >= words.Length || startIndex > endIndex)
            return string.Empty;

        // Выбираем слова в интервале и соединяем их через пробел
        return string.Join(" ", words.Skip(startIndex).Take(endIndex - startIndex + 1));
    }
}