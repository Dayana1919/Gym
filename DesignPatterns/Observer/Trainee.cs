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
        public string PhoneNumber { get; private set; }
        public string Address { get; private set; }
        public string MembershipType { get; private set; }
        public DateTime MembershipExpiry { get; private set; }

        public Trainee(string name, int age, string email, string phoneNumber, string address, string membershipType, DateTime membershipExpiry)
        {
            Name = name;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            MembershipType = membershipType;
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
            Console.WriteLine($"New notification: {message}");
        }

    }
}
