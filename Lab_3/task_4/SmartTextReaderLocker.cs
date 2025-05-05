using System;
using System.Text.RegularExpressions;

public class SmartTextReaderLocker : ISmartTextReader
{
    private ISmartTextReader _reader;
    private Regex _denyPattern;

    public SmartTextReaderLocker(ISmartTextReader reader, string denyRegex)
    {
        _reader = reader;
        _denyPattern = new Regex(denyRegex, RegexOptions.IgnoreCase);
    }

    public char[][] ReadFile(string path)
    {
        if (_denyPattern.IsMatch(path))
        {
            Console.WriteLine("Access denied!");
            return Array.Empty<char[]>();
        }

        return _reader.ReadFile(path);
    }
}