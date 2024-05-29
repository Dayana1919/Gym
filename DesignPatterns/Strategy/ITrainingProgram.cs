using Gym.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Strategy
{
    public interface ITrainingProgram
    {

        public List<TrainingDecorator> Exercises { get; set; }
        public void Create();
    }
}
