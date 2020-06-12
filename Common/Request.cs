using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Common
{
    class Request
    {
        public Object Data { get; set; }
        public List<String> ValidationMessages;
        public Request()
        {
            ValidationMessages = new List<String>();
        }
    }
}
