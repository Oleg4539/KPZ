using System.Collections.Generic;
using System;

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 5.99m;
    public int MinPeriodMonths => 3;
    public List<string> Channels => new List<string> { "Discovery", "Science", "History" };
    public List<string> Features => new List<string> { "Parental Control", "Study Resources" };

    public void ShowInfo()
    {
        Console.WriteLine("Educational Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}