using Gym.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Decorator
{
    public class StrengthDecorator : TrainingDecorator
    {
        public StrengthDecorator(ITrainingProgram decoratedProgram) : base(decoratedProgram) { }

        public override string Execute()
        {
            return base.Execute() + " + Strength exercises";
        }
    }
}
