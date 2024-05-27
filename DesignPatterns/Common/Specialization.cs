using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Common
{
        public class Specialization
        {
            public string SpecializationName { get; private set; }
            public string SpecializationDescription { get; private set; }
            public DateTime SpecializationEndDate { get; private set; }

            public Specialization(string name, string specializationDescr, DateTime certificationDate)
            {
                SpecializationName = name;
                SpecializationDescription = specializationDescr;
                SpecializationEndDate = certificationDate;
            }

            public override string ToString()
            {
                return $"{SpecializationName} on {SpecializationEndDate.ToShortDateString()} - {SpecializationDescription}";
            }
        }
}
