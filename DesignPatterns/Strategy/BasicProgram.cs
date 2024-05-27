using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy
{
    public class BasicProgram :ITrainingProgram
    {
        public string Description { get; private set; }

        public BasicProgram()
        {
            Description = "Основна тренировъчна програма";
        }

        public string Execute()
        {
            return Description;
        }
    }
}
