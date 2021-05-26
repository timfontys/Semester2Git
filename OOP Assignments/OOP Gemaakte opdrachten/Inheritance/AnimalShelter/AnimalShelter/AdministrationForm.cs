using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Dog dog = new Dog(1, birthdayDatePeter, "Peter", walkDatePeter);
            adminstistration.Add(dog);
            listBox1.Items.Add(dog);
            SimpleDate birthdayDateMaxin = new SimpleDate(1, 12, 2010);
            Cat cat = new Cat(2, birthdayDateMaxin, "Maxin", "Raakt geirriteert aan kinderen");
            adminstistration.Add(cat);
            listBox1.Items.Add(cat);
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
                adminstistration.Add(dog);
                listBox1.Items.Add(dog);
            }
            else if (animalTypeComboBox.Text == "Cat") 
            {
                Cat cat = new Cat(Convert.ToInt32(numericUpDownRegistrationNumber.Value), birthDate, textBoxName.Text, textBoxBadHabbits.Text);
                adminstistration.Add(cat);
                listBox1.Items.Add(cat);
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
           listBox3.Items.Add(adminstistration.FindAnimal(Convert.ToInt32(numericUpDownShowChipNumber.Value)));
        }

        private void buttonSetToReserved_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listBox1.SelectedItem;
            animal.IsReserved = true;
            updateListBoxes();
        }

        private void buttonSetToUnreserved_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)listBox1.SelectedItem;
            animal.IsReserved = false;
            updateListBoxes();
        }

        public void updateListBoxes() 
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (Animal animal in adminstistration.animals) 
            {
                if (!animal.IsReserved)
                {
                    listBox1.Items.Add(animal);
                }
                else if (animal.IsReserved) 
                {
                    listBox2.Items.Add(animal);
                }
            }
        }
    }
}
