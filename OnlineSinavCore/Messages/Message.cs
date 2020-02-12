using OnlineSinavCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore
{
   public abstract class Message
    {
        public string Body { get; set; }
        public string Subject { get; set; }
        public IMessageSender MessageSender { get; set; }
        public abstract void Send();
    }
}
