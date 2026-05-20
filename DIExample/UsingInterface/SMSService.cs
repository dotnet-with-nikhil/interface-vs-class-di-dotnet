using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample.UsingInterface
{
    public class SMSService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent");
        }
    }
}
