using System.Collections.Generic;
using System;

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 19.99m;
    public int MinPeriodMonths => 6;
    public List<string> Channels => new List<string> { "All Channels", "4K Movies", "Sports" };
    public List<string> Features => new List<string> { "24/7 Support", "Offline Access", "Multiple Screens" };

    public void ShowInfo()
    {
        Console.WriteLine("Premium Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}