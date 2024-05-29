using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Common.Additions
{
    public class MuscleGainDiet: IAddition
    {
        public override decimal Price { get; set; }
        public override string? Description { get; set; }

        public MuscleGainDiet(decimal price, string description)
        {
            this.Price = price;
            this.Description = description;
        }
    }
}
