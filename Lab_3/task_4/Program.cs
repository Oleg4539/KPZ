using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string fileName = "test.txt";
        File.WriteAllLines(fileName, new[] {
            "Привіт світ!",
            "Це тестовий файл.",
            "Ще один рядок." });

        ISmartTextReader reader = new SmartTextReader();

        Console.WriteLine("\n--- Звичайне читання ---");
        reader.ReadFile(fileName);

        Console.WriteLine("\n--- Через SmartTextChecker (логування) ---");
        ISmartTextReader checker = new SmartTextChecker(reader);
        checker.ReadFile(fileName);

        Console.WriteLine("\n--- Через SmartTextReaderLocker (regex *.secret*) ---");
        ISmartTextReader locker = new SmartTextReaderLocker(reader, ".*secret.*");
        locker.ReadFile("my_secret_notes.txt");
        locker.ReadFile(fileName);

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}