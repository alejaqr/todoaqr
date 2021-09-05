using System;

namespace todoaqr.Common.Responses
{
    internal class Response
    {
        public bool IsSucess { get; set; }

        public string Message { get; set; }
         
        public object Result { get; set; }
    }
}
