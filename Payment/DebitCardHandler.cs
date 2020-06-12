using ChainOfResponsibilityDemo.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Payment
{
  class DebitCardHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod paymentMethod)
            {
                if (paymentMethod.PayType == PaymentType.DebitCard)
                    Console.WriteLine("Processing the debit card payment");
                else if (_nexttHandler != null)
                    _nexttHandler.Process(request);
                else
                    throw new Exception("No handler found");
            }
            else
                throw new Exception("Invalid Payment data!");
        }
    }
}
