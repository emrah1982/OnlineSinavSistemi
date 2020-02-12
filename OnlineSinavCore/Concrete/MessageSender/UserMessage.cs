using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Concrete.MessageSender
{
    public class UserMessage : Message
    {
        public string UserComments { get; set; }
        public override void Send()
        {
            string fullBody = string.Format("{0}\nUser Commets:{1}", Body, UserComments);
            MessageSender.SendMessage(Subject, fullBody);
        }
    }
}
