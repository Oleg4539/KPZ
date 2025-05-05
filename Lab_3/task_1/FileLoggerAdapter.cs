public class FileLoggerAdapter : Logger
{
    private FileWriter _writer;

    public FileLoggerAdapter(FileWriter writer)
    {
        _writer = writer;
    }

    public new void Log(string message)
    {
        _writer.WriteLine("[LOG] " + message);
    }

    public new void Error(string message)
    {
        _writer.WriteLine("[ERROR] " + message);
    }

    public new void Warn(string message)
    {
        _writer.WriteLine("[WARN] " + message);
    }
}
