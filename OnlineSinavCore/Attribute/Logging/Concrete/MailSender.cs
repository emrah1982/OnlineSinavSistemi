using OnlineSinavCore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Attribute.Logging.Concrete
{
    public class MailSender : IMessageSender
    {
        public string SendMessage(string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
