using ChainOfResponsibilityDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Validating
{
    class MaxAgeHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.Age > 55)
                    request.ValidationMessages.Add("Invalid Age");
                if (_nexttHandler != null)
                    _nexttHandler.Process(request);
            }
            else
                throw new Exception("Invalid Message Data");
            
        }
    }
}
