using System;

public class MobileApp : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via MobileApp");
        return new EducationalSubscription();
    }
}