using Gym.Common.Additions;
using Gym.Strategy.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Trainee : IObserver
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public DateTime MembershipStartDate { get; set; }
        public DateTime MembershipExpiry { get; set; }
        public IPayment PaymentMethod { get; set; }

        public List<IAddition> additions { get; set; } = new List<IAddition>();

        public Trainee(string name, int age, string email, string phoneNumber, string address, DateTime membershipStart, DateTime membershipExpiry)
        {
            Name = name;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            MembershipStartDate = membershipStart;
            MembershipExpiry = membershipExpiry;
        }

      
        public void RenewMembership(DateTime newExpiry)
        {
            MembershipExpiry = newExpiry;
            Console.WriteLine($"{Name}'s membership has been renewed until {MembershipExpiry.ToShortDateString()}.");
        }

        public void UpdateContactInfoEmail(string newEmail)
        {
            Email = newEmail;
            Console.WriteLine($"{Name}'s email information has been updated - {newEmail}." );
        }

        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
            Console.WriteLine($"{Name}'s phone number information has been updated - {newPhoneNumber}.");

        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} has new notification: {message}");
        }

        public void MakePayment(decimal totalAmount)
        {
            PaymentMethod.Pay(totalAmount);
        }

        public decimal CalculateAmountToPay(decimal amount, decimal additions)
        {
            return amount + additions;
        }

        public void AddAddition (IAddition addition)
        {
            additions.Add(addition);
            Console.WriteLine($"{this.Name} the {addition.GetType().Name} has been added to your program");
        }
    }
}
