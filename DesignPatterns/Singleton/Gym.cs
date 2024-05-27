using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Gym
    {
        private static Gym gym;
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string WorkingHours { get; private set; }


        private Gym(string name, string location, string workingHours)
        {
            Name = name;
            Location = location;
            WorkingHours = workingHours;
        }

        public static Gym Instance(string name = "Default Gym", string location = "Default Location", string workingHours = "08:00 - 22:00")
        {
            if (gym == null)
            {
                gym = new Gym(name, location, workingHours);
            }
            return gym;
        }

        public void UpdateWorkingHours(string newWorkingHours)
        {
            WorkingHours = newWorkingHours;
        }
    }
}
