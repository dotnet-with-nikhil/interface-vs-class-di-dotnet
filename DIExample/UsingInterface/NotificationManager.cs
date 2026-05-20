using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample.UsingInterface
{
    public class NotificationManager
    {
        private readonly IMessageService _messageService;

        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify()
        {
            _messageService.Send();
        }
    }
}
