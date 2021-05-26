using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    class Adminstistration
    {
        public List<Animal> animals = new List<Animal>();
        public Adminstistration() { }
        public bool Add(Animal animal) 
        {
            foreach (var item in animals) 
            {
                if (item.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    return false;
                }
                
            }
            animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int chipRegistrationNumber) 
        {
            foreach (var item in animals)
            {
                if (item.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.Remove(item);
                    return true;
                }

            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber) 
        {
            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
