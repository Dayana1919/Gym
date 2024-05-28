using DesignPatterns.Observer;
using Gym.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Decorator
{
    public class TrainingDecorator: ITrainingProgram
    {
        protected ITrainingProgram decoratedProgram;

        public TrainingDecorator(ITrainingProgram decoratedProgram)
        {
            this.decoratedProgram = decoratedProgram;
        }

        public virtual string Execute()
        {
            return decoratedProgram.Execute();
        }

        public void UpdateProgram(IObserver trainee)
        {
            
        }
    }
}
