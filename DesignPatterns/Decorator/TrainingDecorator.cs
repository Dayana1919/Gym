using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using Gym.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Decorator
{
    public abstract class TrainingDecorator : ITrainingProgram
    {
        protected ITrainingProgram decoratedProgram;
        public string Name;

        public TrainingDecorator(ITrainingProgram decoratedProgram, string name)
        {
            this.decoratedProgram = decoratedProgram;
            this.Name = name;
        }

        public List<TrainingDecorator> Exercises { get; set; }

        public void Create()
        {
             decoratedProgram.Create();
        }

    }
}
