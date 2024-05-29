﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Common.Additions
{
    public class MuscleSupplements: IAddition
    {
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public MuscleSupplements(decimal price, string description)
        {
            this.Price = price;
            this.Description = description;
        }

        public void Execute()
        {
            Console.WriteLine($"Addition {this.Description} with price {this.Price}");
        }
    }
}
