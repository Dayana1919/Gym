using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public class CreditCard : IPayment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }

        public string CVV { get; set; }

        public CreditCard(string cardNumber, string cardHolderName, string expiryDate, string cVV)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            CVV = cVV;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card {CardNumber}.");
        }

        public bool IsPaymentMethodInfoValid()
        {
            return true;
        }

    }
}
