using ChainOfResponsibilityDemo.Common;
using ChainOfResponsibilityDemo.Payment;
using ChainOfResponsibilityDemo.Validating;
using System;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        static void ValidatePerson()
        {
            var person = new Person() { Name = "John Doe", Age = 60, Income = 1500f };
            var request = new Request() { Data = person };
            var maxAgeHandler = new MaxAgeHandler();
            var maxNameLengthHandler = new MaxNameLengthHandler();
            var maxIncomeHandler = new MaxIncomeHandler();
            maxAgeHandler.SetNexthandler(maxNameLengthHandler);
            maxNameLengthHandler.SetNexthandler(maxIncomeHandler);
            maxAgeHandler.Process(request);

            foreach (var msg in request.ValidationMessages)
                Console.WriteLine(msg);
        }

        static void PayBill()
        {
            var paymentMethod          = new PaymentMethod() { PayType = PaymentType.NetBanking };
            var creditCardHandler      = new CreditCardHandler();
            var debitCardHandler       = new DebitCardHandler();
            var paymentWalletHandler   = new PaymentWalletHandler();
            var netBankingHandler      = new NetBankingHandler();
            creditCardHandler.SetNexthandler(debitCardHandler);
            debitCardHandler.SetNexthandler(paymentWalletHandler);
            paymentWalletHandler.SetNexthandler(netBankingHandler);
            creditCardHandler.Process(new Request() { Data = paymentMethod});

        }

        static void Main(string[] args)
        {
            ValidatePerson();
            PayBill();
            Console.ReadLine();
        }
    }
}
