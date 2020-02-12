using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavModel
{
   public class LogVeri
    {
        private static List<LogBilgi> _loglar = new List<LogBilgi>();
        public static List<LogBilgi> Loglar { get { return _loglar; } }
    }
}
