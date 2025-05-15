using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsRecords
{
    public record Employee : Person
    {
        public string Role;
        public Employee(string name, int age, string role) : base(name, age)
        {
            Role = role;
        }
    }
}
