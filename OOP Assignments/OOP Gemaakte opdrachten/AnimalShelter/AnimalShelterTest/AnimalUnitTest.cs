using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTest
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void WhenAddingADogThenTheSizeOfTheListGoesUp()
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Dog dog = new Dog(500, birthDate, "peter", lastWalkDate);
            Assert.AreEqual(true, adminstistration.Add(dog));
            int size = adminstistration.Animals.Count;
            Assert.AreEqual(1, size);
            Assert.IsTrue(adminstistration.Animals.Contains(dog));
        }

        [TestMethod]
        public void WhenAddingACatThenTheSizeOfTheListGoesUp()
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Cat cat = new Cat(500, birthDate, "peter", "scratches");
            Assert.AreEqual(true, adminstistration.Add(cat));
            int size = adminstistration.Animals.Count;
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Chip registraion number is already in use")]
        public void WhenAddingTheSameDogTwiceThenItReturnsAExeptionAndDoesntAddItToTheList() 
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Dog dog = new Dog(500, birthDate, "peter", lastWalkDate);
            Assert.IsTrue(adminstistration.Add(dog));
            Dog secondDog = new Dog(500, birthDate, "peter", lastWalkDate);
            adminstistration.Add(secondDog);

            int size = adminstistration.Animals.Count;
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Chip registraion number is already in use")]
        public void WhenAddingTheSameCatTwiceThenItReturnsAExeptionAndDoesntAddItToTheList()
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Cat cat = new Cat(500, birthDate, "peter", "Scratches");
            Assert.IsTrue(adminstistration.Add(cat));
            Cat secondCat = new Cat(500, birthDate, "peter", "scratches");
            adminstistration.Add(secondCat);
            int size = adminstistration.Animals.Count;
            Assert.AreEqual(1, size);
        }

        [TestMethod]
        public void WhenTryingToFindANonExistingAnimalThenItReturnsNull() 
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Cat cat = new Cat(1, birthDate, "peter", "Scratches");
            adminstistration.Add(cat);
            Assert.IsNull(adminstistration.FindAnimal(-1));
            Assert.AreEqual(cat, adminstistration.FindAnimal(1));
        }

        [TestMethod]
        public void WhenCheckingTheDogPriceThenItGivesTheRightPrice() 
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            SimpleDate lastWalkDate = new SimpleDate(12, 8, 2020);
            Dog dog = new Dog(49999, birthDate, "peter", lastWalkDate);
            Dog dog2 = new Dog(50000, birthDate, "peter", lastWalkDate);
            Dog dog3 = new Dog(50001, birthDate, "peter", lastWalkDate);
            Assert.IsTrue(adminstistration.Add(dog));
            Assert.IsTrue(adminstistration.Add(dog2));
            Assert.IsTrue(adminstistration.Add(dog3));
            int size = adminstistration.Animals.Count;
            Assert.AreEqual(200, dog.Price);
            Assert.AreEqual(350, dog2.Price);
            Assert.AreEqual(350, dog3.Price);
            Assert.AreEqual(3, size);
        }

        [TestMethod]
        public void WhenCheckingTheCatPriceThenItGivesTheRightPrice()
        {
            Adminstistration adminstistration = new Adminstistration();
            SimpleDate birthDate = new SimpleDate(10, 10, 2000);
            Cat cat = new Cat(500, birthDate, "peter", "12345678901234567890123456789012345678");
            Cat cat2 = new Cat(501, birthDate, "peter", "123456789012345678901234567890123456789");
            Cat cat3 = new Cat(502, birthDate, "peter", "1234567890123456789012345678901234567890");
            Cat cat4 = new Cat(503, birthDate, "peter", "12345678901234567890123456789012345678901");
            Assert.AreEqual(true, adminstistration.Add(cat));
            Assert.AreEqual(true, adminstistration.Add(cat2));
            Assert.AreEqual(true, adminstistration.Add(cat3));
            Assert.AreEqual(true, adminstistration.Add(cat4));
            int size = adminstistration.Animals.Count;
            Assert.AreEqual(4, size);
            Assert.AreEqual(22, cat.Price);
            Assert.AreEqual(21, cat2.Price);
            Assert.AreEqual(20, cat3.Price);
            Assert.AreEqual(20, cat4.Price);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Animal is Null")]
        public void WhenAddingNullValuesThenNullExeptionsWillBeThrown() 
        {
            Adminstistration adminstistration = new Adminstistration();
            Assert.AreEqual(true, adminstistration.Add(null));
        }

    }
}