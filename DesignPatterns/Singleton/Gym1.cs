using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Gym1
    {
        private static Gym1 gym;
        public string Name { get; set; }
        public string Location { get; set; }
        public string WorkingHours { get; set; }

        private Gym1(string name, string location, string workingHours)
        {
            Name = name;
            Location = location;
            WorkingHours = workingHours;
        }

        public static Gym1 Instance(string name, string location, string workingHours)
        {
            if (gym == null)
            {
                gym = new Gym1(name, location,workingHours);
            }
            return gym;
        }

        public void UpdateWorkingHours(string newWorkingHours)
        {
            WorkingHours = newWorkingHours;
        }
    }
}
