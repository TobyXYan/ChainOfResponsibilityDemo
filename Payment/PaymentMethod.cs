using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDemo.Payment
{
    enum PaymentType
    {
        CreditCard = 1,
        DebitCard,
        PaymentWallet,
        NetBanking
    }
    class PaymentMethod
    {
        public PaymentType PayType;

    }


}
