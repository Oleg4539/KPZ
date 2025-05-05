using System.Collections.Generic;
using System;

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 10.99m;
    public int MinPeriodMonths => 1;
    public List<string> Channels => new List<string> { "National TV", "News", "Kids" };
    public List<string> Features => new List<string> { "Basic Support" };

    public void ShowInfo()
    {
        Console.WriteLine("Domestic Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}