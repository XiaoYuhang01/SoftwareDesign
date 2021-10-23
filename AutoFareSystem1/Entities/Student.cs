using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFareSystem1
{
    public class Student : User
    {
        public ElctronicFare EFare { get; set; }
        public WaterFare WFare { get; set; }
        public override string Id { get ; set; }
        public override string Name { get; set; }
        public override string Password { get; set; }
        
        public double EFareAmount { get => EFare.Amount; }
        public double WFareAmount { get => WFare.Amount; }

        public bool IfUseOk { get; set; }

        public Student(string id, string name) : base(id, name) { Id = id; Name = name;}

        public override string ToString()
        {
            return Id + Name;
        }

        public override bool Equals(object obj)
        {
            if(obj == null) { return false; }
            if (obj.GetType() != this.GetType()) { return false; }
            else { return this.Id + this.Name == obj.ToString(); }
        }
    }
}
