using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        Adminstistration adminstistration = new Adminstistration();
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            SimpleDate birthdayDatePeter = new SimpleDate(5, 9, 2000);
            SimpleDate walkDatePeter = new SimpleDate(10, 12, 2020);
            SimpleDate walkDateJan = new SimpleDate(15, 10, 2010);
            SimpleDate birthdayDateJan = new SimpleDate(5, 9, 2002);
            Dog dog = new Dog(1, birthdayDatePeter, "Peter", walkDatePeter);
            adminstistration.Add(dog);
            listBox1.Items.Add(dog);
            SimpleDate birthdayDateMaxin = new SimpleDate(1, 12, 2010);
            Cat cat = new Cat(2, birthdayDateMaxin, "Maxin", "Raakt geirriteert aan kinderen");
            adminstistration.Add(cat);
            listBox1.Items.Add(cat);
            Dog dog2 = new Dog(3, birthdayDateJan, "Jan", walkDateJan);
            adminstistration.Add(dog2);
            listBox1.Items.Add(dog2);
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            SimpleDate birthDate = new SimpleDate(Convert.ToInt32(numericUpDownBirthDay.Value), Convert.ToInt32(numericUpDownBirthMonth.Value), Convert.ToInt32(numericUpDownBirthYear.Value));
            if (animalTypeComboBox.Text == "Dog")
            {
                SimpleDate lastWalkDate = new SimpleDate(Convert.ToInt32(numericUpDownLastWalkDay.Value), Convert.ToInt32(numericUpDownLastWalkMonth.Value), Convert.ToInt32(numericUpDownLastWalkYear.Value));
                Dog dog = new Dog(Convert.ToInt32(numericUpDownRegistrationNumber.Value), birthDate, textBoxName.Text, lastWalkDate);
                try
                {
                    adminstistration.Add(dog);
                    listBox1.Items.Add(dog);
                }
                catch (ArgumentNullException exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
                catch (ArgumentException exeption) 
                {
                    MessageBox.Show(exeption.Message);
                }
            }
            else if (animalTypeComboBox.Text == "Cat") 
            {
                Cat cat = new Cat(Convert.ToInt32(numericUpDownRegistrationNumber.Value), birthDate, textBoxName.Text, textBoxBadHabbits.Text);
                try
                {
                    adminstistration.Add(cat);
                    listBox1.Items.Add(cat);
                }
                catch (ArgumentNullException exeption)
                {
                    MessageBox.Show(exeption.Message);
                }
                catch (ArgumentException exeption) 
                {
                    MessageBox.Show(exeption.Message);
                }
        }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            if (numericUpDownShowChipNumber.Value > 0)
            {
                listBox3.Items.Add(adminstistration.FindAnimal(Convert.ToInt32(numericUpDownShowChipNumber.Value)));
            }
            else 
            {
                MessageBox.Show("Please fill in a Chip Number");
            }
        }

        private void buttonSetToReserved_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Animal animal = (Animal)listBox1.SelectedItem;
                animal.IsReserved = true;
                updateListBoxes();
            }
            else { MessageBox.Show("Please select a animal"); }
        }

        private void buttonSetToUnreserved_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                Animal animal = (Animal)listBox2.SelectedItem;
                animal.IsReserved = false;
                updateListBoxes();
            }
            else { MessageBox.Show("Please select a animal"); }
        }

        public void updateListBoxes() 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (Animal animal in adminstistration.Animals) 
            {
                if (!animal.IsReserved)
                {
                    listBox1.Items.Add(animal);
                }
                else 
                {
                    listBox2.Items.Add(animal);
                }
            }
        }

        private void sortChipIdButton_Click(object sender, EventArgs e)
        {
            adminstistration.Animals.Sort();
            updateListBoxes();
        }

        private void buttonShowAllBadHabbitsAndWalkDates_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            foreach(Animal animal in adminstistration.Animals) 
            {
                if (animal is Dog dog) 
                {
                    listBox4.Items.Add(dog.LastWalkDate);
                }
                Cat cat = animal as Cat;
                if (cat != null) 
                {
                    listBox4.Items.Add(cat.BadHabits);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            adminstistration.Save(@"C:\FileIo\file.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            adminstistration.Load(@"C:\FileIo\file.txt");
            updateListBoxes();
        }
    }
}
