using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample.UsingInterface
{
    public interface IMessageService
    {
        void Send();
    }
}


// I dont' care who sends the message
// I only need Send Method()

//CONTRACT