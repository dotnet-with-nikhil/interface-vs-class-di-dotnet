using DIExample.UsingInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample.UsingClass
{
    public class NotificationManager
    {
        //private readonly EmailService _emailService;


        //public NotificationManager(EmailService emailService)
        //{
        //    _emailService = emailService;
        //}


        private readonly SMSService _smsService;

        public NotificationManager(SMSService smsService)
        {
            _smsService = smsService;
        }

        public void Notify()
        {
            _smsService.Send();
        }
    }
}

//maintenance issue
//scalability issue
//difficult testing
//continuous code modification
