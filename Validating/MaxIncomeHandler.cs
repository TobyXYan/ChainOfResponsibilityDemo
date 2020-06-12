using ChainOfResponsibilityDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Validating
{
    class MaxIncomeHandler:BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is Person person)
            {
                if (person.Income > 1000)
                    request.ValidationMessages.Add("Invalid Income");
                if (_nexttHandler != null)
                    _nexttHandler.Process(request);
            }
            else
                throw new Exception("Invalid Message Data");

        }
    }
}
