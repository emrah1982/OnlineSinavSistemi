using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Abstract
{
    //Kaynak https://www.dotnettricks.com/learn/designpatterns/bridge-design-pattern-dotnet
    public interface IMessageSender
    {
        string SendMessage(string subject,string body);
    }
}
