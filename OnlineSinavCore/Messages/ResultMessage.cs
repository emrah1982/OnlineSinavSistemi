using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavCore.Messages
{
    /// <summary>
    /// Generic Result Message olusturmak için
    /// </summary>
    /// <typeparam name="T">Classların yazıldığı yer</typeparam>
   public class ResultMessage<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T  Data { get; set; }
    }
}
