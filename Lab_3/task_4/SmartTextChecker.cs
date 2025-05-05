using System;

public class SmartTextChecker : ISmartTextReader
{
    private ISmartTextReader _reader;

    public SmartTextChecker(ISmartTextReader reader)
    {
        _reader = reader;
    }

    public char[][] ReadFile(string path)
    {
        Console.WriteLine($"Відкриття файлу: {path}");

        char[][] result = _reader.ReadFile(path);

        Console.WriteLine($"Файл прочитано успішно.");
        Console.WriteLine($"Рядків: {result.Length}");

        int symbols = 0;
        foreach (var row in result)
            symbols += row.Length;

        Console.WriteLine($"Символів: {symbols}");

        return result;
    }
}