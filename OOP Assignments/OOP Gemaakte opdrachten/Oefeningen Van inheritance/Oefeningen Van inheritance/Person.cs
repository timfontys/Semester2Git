using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_Van_inheritance
{
    class Person
    {
        public string Name { get; private set; }
        public int PhoneNumber { get; private set; }    
        public string Email { get; private set; }
        public Person(string name, int phoneNumber, string email) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
 
    }
}
