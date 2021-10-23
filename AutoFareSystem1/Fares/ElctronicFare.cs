using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFareSystem1
{
    public class ElctronicFare:Fare
    {
        public override string typeId { get; set; }
        public override double Amount { get; set; }

        public ElctronicFare(double amount):base(amount)
        {
            typeId = "1";
            Amount = amount;
        }
    }
}
