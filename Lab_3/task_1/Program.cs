using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Logger consoleLogger = new Logger();
        consoleLogger.Log("Це звичайне повідомлення");
        consoleLogger.Warn("Це попередження");
        consoleLogger.Error("Це помилка");

        FileWriter fileWriter = new FileWriter("log.txt");
        Logger fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("Це лог у файл");
        fileLogger.Warn("Це попередження у файл");
        fileLogger.Error("Це помилка у файл");

        Console.WriteLine("Готово. Перевірте файл log.txt.");
        Console.WriteLine("Натисніть Enter для завершення...");
        Console.ReadLine();
    }
}
