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
        public new string Name;
        public ConditionalDecorator(ITrainingProgram decoratedProgram, string name) : base(decoratedProgram,name) 
        {
        }

        public new void Create()
        {
            base.Create();
            if (decoratedProgram is BasicProgram basicProgram)
            {
                basicProgram.Exercises.Add(this);
            }
            Console.WriteLine($"Adding Conditional exercise: {this.Name}");
        }
    }
}
