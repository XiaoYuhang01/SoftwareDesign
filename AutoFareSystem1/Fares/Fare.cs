using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFareSystem1
{
    public abstract class Fare
    {
        public abstract string typeId { get; set; }
        public abstract double Amount { get; set; }

        public Fare(double amount)
        {
            Amount = amount;
        }
    }
}
