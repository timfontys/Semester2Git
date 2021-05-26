using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalWentBad
{
    public partial class RentalAdministrationForm : Form
    {
        private RentalAdministration administration;

        /// <summary>
        /// Contains a UI to test the RentalAdministration.
        /// </summary>
        public RentalAdministrationForm()
        {
            InitializeComponent();
            miniBarComboBox.SelectedIndex = 0;
            towBarComboBox.SelectedIndex = 0;
            rentalDateTimePicker.Value = DateTime.Today;
            returnDateTimePicker.Value = DateTime.Today;
            administration = new RentalAdministration();
            AddSomeCars();
        }

        /// <summary>
        /// Add some test cars
        /// </summary>
        private void AddSomeCars()
        {
            administration.Add(new Sedan("Opel", "Insignia 2.2L", 2000, "412412", false));
            administration.Add(new Sedan("Skoda", "Oktavia 1.8T", 2010, "412441", true));
            administration.Add(new Truck("DAF", "LF45 FR118", 1990, "421422", 50, 1000));
            administration.Add(new Limousine("Lincoln", "Learjet", 1970, "4124122", true));
            UpdateAvailableCarListAndRentedCarLists();
        }


        /// <summary>
        /// Adds a truck to the adminitration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTruckButton_Click(object sender, EventArgs e)
        {
            string licencePlate = licencePlateTextBox.Text;
            int cargoSpace;
            int maxWeight;
            int buildYear = Convert.ToInt32(numericUpDownBuildYear.Value);
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && Int32.TryParse(cargoSpaceTextBox.Text, out cargoSpace)
                && Int32.TryParse(maxWeightTextBox.Text, out maxWeight))
            {
                Truck truck = new Truck(manufacturerTextBox.Text, modelTextBox.Text, buildYear, licencePlate, cargoSpace, maxWeight);
                administration.Add(truck);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the truck is entered or the data entered has the wrong format.");
            }
        }


        /// <summary>
        /// Adds a limousine to the administration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addLimousineButton_Click(object sender, EventArgs e)
        {
            int buildYear = Convert.ToInt32(numericUpDownBuildYear.Value);
            string licencePlate = licencePlateTextBox.Text;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && (miniBarComboBox.Text == "Yes" || miniBarComboBox.Text == "No"))
            {
                bool hasMiniBar = miniBarComboBox.Text == "Yes";
                Limousine limousine = new Limousine(manufacturerTextBox.Text, modelTextBox.Text, buildYear, licencePlate, hasMiniBar);
                administration.Add(limousine);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the limousine is entered or the data entered has the wrong format.");
            }
        }

        /// <summary>
        /// Adds a sedan to the administration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSedanButton_Click(object sender, EventArgs e)
        {
            int buildYear = Convert.ToInt32(numericUpDownBuildYear.Value);
            string licencePlate = licencePlateTextBox.Text;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && (towBarComboBox.Text == "Yes" || towBarComboBox.Text == "No"))
            {
                bool hasTowBar = towBarComboBox.Text == "Yes";
                Sedan sedan = new Sedan(manufacturerTextBox.Text, modelTextBox.Text, buildYear, licencePlate, hasTowBar);
                administration.Add(sedan);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the sedan is entered or the data entered has the wrong format.");
            }
        }

        private void addOffRoadButton_Click(object sender, EventArgs e)
        {
            int buildYear = Convert.ToInt32(numericUpDownBuildYear.Value);
            string licencePlate = licencePlateTextBox.Text;
            if (manufacturerTextBox.Text.Trim().Length != 0
                && modelTextBox.Text.Trim().Length != 0
                && (fourWheelDriveComboBox.Text == "Yes" || fourWheelDriveComboBox.Text == "No"))
            {
                bool hasFourWheelDrive = fourWheelDriveComboBox.Text == "Yes";
                OffRoad offRoad = new OffRoad(manufacturerTextBox.Text, modelTextBox.Text, buildYear, licencePlate, hasFourWheelDrive);
                administration.Add(offRoad);
                UpdateAvailableCarListAndRentedCarLists();
            }
            else
            {
                MessageBox.Show("Not all data of the sedan is entered or the data entered has the wrong format.");
            }
        }
        /// <summary>
        /// Updates the GUI list of available and rented cars.
        /// </summary>
        private void UpdateAvailableCarListAndRentedCarLists()
        {
            availableCarsListBox.Items.Clear();
            rentedCarsListBox.Items.Clear();

            List<Car> cars = administration.Cars;
            foreach (Car car in cars)
            {
                if (car.IsAvailable)
                {
                    availableCarsListBox.Items.Add(car);
                }
                else
                {
                    rentedCarsListBox.Items.Add(car);
                }
            }
        }

        /// <summary>
        /// Rent the car using the licence plate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rentCarButton_Click(object sender, EventArgs e)
        {
            string licencePlate = rentalLicencePlateTextBox.Text;
            
                SimpleDate date = new SimpleDate(rentalDateTimePicker.Value.Day,
                                                 rentalDateTimePicker.Value.Month,
                                                 rentalDateTimePicker.Value.Year);
                bool isRented = administration.RentCar(licencePlate, date);
                if (isRented)
                {
                    UpdateAvailableCarListAndRentedCarLists();
                }
                else
                {
                    MessageBox.Show("There's no car with licence plate: '"
                                    + licencePlate + "' or the car is already rented.");
                }
            
        }

        /// <summary>
        /// Return a car using the licence plate number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnCarButton_Click(object sender, EventArgs e)
        {
            string licencePlate = returnLicencePlateTextBox.Text;
            int kilometers;
            if (Int32.TryParse(returnKilometersTextBox.Text, out kilometers))
            {
                SimpleDate date = new SimpleDate(returnDateTimePicker.Value.Day,
                    returnDateTimePicker.Value.Month,
                    returnDateTimePicker.Value.Year);
                decimal price = administration.ReturnCar(licencePlate, date, kilometers);
                if (price >= 0)
                {
                    MessageBox.Show("Please Pay: '" + price + " credits'.");
                    UpdateAvailableCarListAndRentedCarLists();
                }
                else
                {
                    MessageBox.Show("No Car with licence plate: '" + licencePlate
                        + "'\nor the kilometers are less then when rented\nor the return date is invalid (before rental date)\nor the car was not rented and cannot be returned.");
                }
            }
            else
            {
                MessageBox.Show("The licence plate and/or kilometers are entered wrong format.");
            }
        }


    }
}
