using System.Collections.Generic;

public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinPeriodMonths { get; }
    List<string> Channels { get; }
    List<string> Features { get; }
    void ShowInfo();
}
