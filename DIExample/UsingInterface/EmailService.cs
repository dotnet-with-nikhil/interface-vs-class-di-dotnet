using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample.UsingInterface
{
    public class EmailService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
}
