using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public class GooglePay : IPayment
    {
        public string GooglePayId { get; set; }

        public GooglePay(string googlePayId)
        {
            GooglePayId = googlePayId;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Google Pay {GooglePayId}.");
        }
        public bool IsPaymentMethodInfoValid()
        {
            return true;
        }
    }
}
