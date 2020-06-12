using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Common
{
    class BaseHandler : IHandler
    {
        protected IHandler _nexttHandler;

        public BaseHandler()
        {
            _nexttHandler = null;
        }
        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public void SetNexthandler(IHandler handler)
        {
            _nexttHandler = handler;
        }
    }
}
