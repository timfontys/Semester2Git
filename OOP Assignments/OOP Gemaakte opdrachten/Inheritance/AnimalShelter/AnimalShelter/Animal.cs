using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    /// <summary>
    /// Class representing an animal in the shelter.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// The chipnumber of the animal. Must be unique. Must be zero or greater than zero.
        /// </summary>
        public int ChipRegistrationNumber { get; private set; }

        /// <summary>
        /// Date of birth of the animal.
        /// </summary>
        public SimpleDate DateOfBirth { get; private set; }

        /// <summary>
        /// The name of the animal.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Is the animal reserved by a future owner yes or no.
        /// </summary>
        public bool IsReserved { get; set; }

        /// <summary>
        /// Creates an animal.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        public Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
        }

        /// <summary>
        /// Retrieve information about this animal
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "<ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise. 
        /// </returns>
        public override string ToString()
        {
            string IsReservedString;
            if (IsReserved)
            {
                IsReservedString = "reserved";
            }
            else
            {
                IsReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + IsReservedString;
            return info;
        }
    }
}
