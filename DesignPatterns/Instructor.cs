using DesignPatterns.Observer;
using Gym.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Instructor
    {
        public string Name { get; private set; }
        public string Certification { get; private set; }
        public int YearsExperience { get; private set; }
        public List<Specialization> Specializations { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        private List<IObserver> trainees = new List<IObserver>();

        public Instructor(string name, string certification, int experience, 
            List<Specialization> specializations, string email, string phoneNumber)
        {
            Name = name;
            Certification = certification;
            YearsExperience = experience;
            Specializations = specializations;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public void AddSpecialization(Specialization specialization)
        {
            Specializations.Add(specialization);
            NotifyTrainees("Instructor specializations have been updated");
        }
        public void AddTrainee(IObserver trainee)
        {
            trainees.Add(trainee);
        }

        public void RemoveTrainee(IObserver trainee)
        {
            trainees.Remove(trainee);
        }

        public void UpdateYearsOfExperience(int years)
        {
            YearsExperience = years;
        }
        public void NotifyTrainees(string message)
        {
            foreach (var trainee in trainees)
            {
                trainee.Update(message);
            }
        }

        public void UpdateContactInfoEmail(string newEmail)
        {
            Email = newEmail;
            NotifyTrainees($"Instructor email has been updated.");
        }

        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
            NotifyTrainees($"Instructor phone has been updated.");

        }
    }
}
