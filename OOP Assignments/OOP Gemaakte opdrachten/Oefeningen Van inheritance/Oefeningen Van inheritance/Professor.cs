using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_Van_inheritance
{
        class Professor : Person
    {
        public int Salary { get; private set; }

        public Professor(string name, int phoneNumber, string email, int salary) : base(name, phoneNumber, email)
        {
            Salary = salary;
        }
        public override string ToString()
        {
            return Name + Salary;
        }
    }
}
