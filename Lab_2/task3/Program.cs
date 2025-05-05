using System;

class Program
{
    static void Main(string[] args)
    {
        var auth1 = Authenticator.Instance;
        var auth2 = Authenticator.Instance;

        Console.WriteLine($"Token 1: {auth1.Token}");
        Console.WriteLine($"Token 2: {auth2.Token}");

        Console.WriteLine(auth1 == auth2
            ? "Один і той самий екземпляр"
            : "Різні екземпляри");
        Console.ReadLine();
    }
}
