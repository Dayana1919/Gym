using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public class BankTransfer: IPayment
    {
        public string BankAccountNumber { get; set; }
        public string BankName { get; set; }

        public BankTransfer(string bankAccountNumber, string bankName)
        {
            BankAccountNumber = bankAccountNumber;
            BankName = bankName;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} via bank transfer to {BankAccountNumber} at {BankName}.");
        }

        public bool IsPaymentMethodInfoValid()
        {
            return true;
        }
    }
}
