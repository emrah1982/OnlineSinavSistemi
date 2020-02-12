using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Attribute.Logging.Abstract
{
    interface ILog
    {
        void WriteLog(string message);
    }
}
