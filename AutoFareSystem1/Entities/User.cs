using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFareSystem1
{
    public abstract class User
    {
        public abstract string Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Password { get; set; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
