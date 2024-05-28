using Gym.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Decorator
{
    public class ConditionalDecorator : TrainingDecorator
    {
        public ConditionalDecorator(ITrainingProgram decoratedProgram) : base(decoratedProgram) { }

        public override string Execute()
        {
            return base.Execute() + " + Conditional exercises";
        }
    }
}
