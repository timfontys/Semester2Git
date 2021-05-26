using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_Van_inheritance
{
    class Student : Person
    {
        public int StudentNumber { get; private set; }


        public Student(string name, int phoneNumber, string email, int studentNumber) : base(name, phoneNumber, email)
        {
            StudentNumber = studentNumber;
        }

        public override string ToString()
        {
            return Name + StudentNumber; 
        }

        public virtual int LongerPhoneNumber(int longerPhoneNumber)
        {
            longerPhoneNumber *= 10;
            return longerPhoneNumber;
        }
    }
}
