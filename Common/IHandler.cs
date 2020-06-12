using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Common
{
    interface IHandler
    {
        void SetNexthandler(IHandler handler);
        void Process(Request request);
    }
}
