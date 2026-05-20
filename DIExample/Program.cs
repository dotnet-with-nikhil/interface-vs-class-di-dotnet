//using DIExample.UsingClass;
using DIExample.UsingInterface;

//using DIExample.UsingInterface;
using System;

class Program
{
    static void Main(string[] args)
    {
        //EmailService emailService = new EmailService();
        //SMSService smsService = new SMSService();

        //NotificationManager manager =
        //    new NotificationManager(smsService);

        //manager.Notify();

        //Console.ReadLine();

        IMessageService service =
           new SMSService();

        NotificationManager manager =
            new NotificationManager(service);

        manager.Notify();

        Console.ReadLine();
    }
}