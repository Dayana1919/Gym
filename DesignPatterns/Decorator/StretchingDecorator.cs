using Gym.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Decorator
{
    public class StretchingDecorator : TrainingDecorator
    {
        public new string Name;
        public StretchingDecorator(ITrainingProgram decoratedProgram, string name) : base(decoratedProgram, name) 
        {
           
        }

        public new void Create()
        {
            base.Create();
            if (decoratedProgram is BasicProgram basicProgram)
            {
                basicProgram.Exercises.Add(this);
            }
            AddExercise();
        }

        private void AddExercise()
        {
            Console.WriteLine($"Adding Stretching exercise: {this.Name}");
        }
    }
}
