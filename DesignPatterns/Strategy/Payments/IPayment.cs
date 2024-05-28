using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy.Payments
{
    public interface IPayment
    {
        void Pay(decimal amount);
        bool IsPaymentMethodInfoValid();
    }
}
