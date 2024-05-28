using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public class Skrill
    {
        public string SkrillId { get; set; }

        public Skrill(string skrillId)
        {
            SkrillId = skrillId;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Skrill {SkrillId}.");
        }

        public bool IsPaymentMethodInfoValid()
        {
            return true;
        }
    }
}
