using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public class PayPal:IPayment
    {
        public string Email { get; set; }

        public PayPal(string email)
        {
            Email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal {Email}.");
        }

        public bool IsPaymentMethodInfoValid()
        {
            return true;
        }
    }
}
