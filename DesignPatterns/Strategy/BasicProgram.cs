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
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        public List<TrainingDecorator> Exercises { get; set; }

        public BasicProgram(decimal price)
        {
            Description = "Basic Training Program";
            Price = price;
            this.Exercises = new List<TrainingDecorator>();
        }

        public void Create()
        {
            Console.WriteLine($"Creating {Description} with price {Price}.");
            foreach (var exercise in Exercises)
            {
                Console.WriteLine($"Exercise: {exercise.Name}");
            }
        }


    }
}
