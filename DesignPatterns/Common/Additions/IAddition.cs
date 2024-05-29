using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Common.Additions
{
    public interface IAddition
    {
        public decimal Price { get; set; }

        public string? Description { get; set; }
        void Execute();
    }
}
