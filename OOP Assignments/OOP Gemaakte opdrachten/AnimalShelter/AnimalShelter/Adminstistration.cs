using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace AnimalShelter
{
    public class Adminstistration
    {
        public List<Animal> Animals { get; private set; }

        public Adminstistration()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal) 
        {
            if (animal == null)
            { 
                throw new ArgumentNullException("Animal is Null"); 
            }
            if (FindAnimal(animal.ChipRegistrationNumber) != null)
            {
                throw new ArgumentException("Chip registraion number is already in use");
            }
            Animals.Add(animal);
            return true;
        }

        public bool RemoveAnimal(int chipRegistrationNumber) 
        {
            Animal animal = FindAnimal(chipRegistrationNumber);
            if (animal == null)
            {
                throw new ArgumentException("Cant remove non existing animal");
            }
            Animals.Remove(animal);
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber) 
        {
            foreach (Animal animal in Animals)
            {
                if (animal.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return animal;
                }
            }
            return null;
        }

        public void Save(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(file, Animals);
            }
        }

        public void Load(string fileName) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream file = new FileStream(fileName, FileMode.Open))
            {
               Animals = (List<Animal>)formatter.Deserialize(file);
            }
        }
    }
}
