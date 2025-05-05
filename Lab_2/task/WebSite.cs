using System;

public class WebSite : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via WebSite");
        return new DomesticSubscription();
    }
}