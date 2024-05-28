using Gym.Decorator;
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
        public decimal Price { get; private set; }
        public List<TrainingDecorator> excersices = new List<TrainingDecorator>();

        public BasicProgram(decimal price)
        {
            Description = "Basic Training Program";
            Price = price;
        }

        public void Execute()
        {
            Console.WriteLine($"Basic program with price ${this.Price}");
        }


    }
}
