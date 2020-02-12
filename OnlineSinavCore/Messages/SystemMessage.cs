using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Messages
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
