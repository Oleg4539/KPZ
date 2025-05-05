using System;

class Program
{
    static void Main(string[] args)
    {
        SubscriptionCreator creator1 = new WebSite();
        ISubscription sub1 = creator1.CreateSubscription();
        sub1.ShowInfo();

        SubscriptionCreator creator2 = new MobileApp();
        ISubscription sub2 = creator2.CreateSubscription();
        sub2.ShowInfo();

        SubscriptionCreator creator3 = new ManagerCall();
        ISubscription sub3 = creator3.CreateSubscription();
        sub3.ShowInfo();
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }

}