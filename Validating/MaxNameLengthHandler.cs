using ChainOfResponsibilityDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Validating
{
    class MaxNameLengthHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.Name.Length > 10)
                    request.ValidationMessages.Add("Invalid Name");
                if (_nexttHandler != null)
                    _nexttHandler.Process(request);
            }
            else
                throw new Exception("Invalid Message Data");

        }
    }
}
