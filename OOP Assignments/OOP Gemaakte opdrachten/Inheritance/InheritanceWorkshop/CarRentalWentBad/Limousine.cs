using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class Limousine
    {
        /// <summary>
        /// The manufacturer of the limousine
        /// </summary>
        public string Manufacturer { get; private set; }

        /// <summary>
        /// The model of the limousine
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// The licence plate of the limousine
        /// </summary>
        public int LicencePlate { get; private set; }

        /// <summary>
        /// The total number of kilometers the limousine has driven.
        /// </summary>
        public int Kilometers { get; private set; }

        /// <summary>
        /// Limousine availability for rental 
        /// </summary>
        public bool IsAvailable
        {
            get { return RentalDate == null; }
        }

        /// <summary>
        /// The starting date of the rental period. Contains null if not rented (IsAvailable == true).
        /// </summary>
        public SimpleDate RentalDate { get; private set; }

        /// <summary>
        /// Does the limousine have a minibar for storing cold drinks.
        /// </summary>
        public bool HasMinibar { get; private set; }

        /// <summary>
        /// Creates a limousine
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the limousine</param>
        /// <param name="model">The model of the limousine</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="hasMinibar">Does the limousine have a minibar for cold drinks?</param>
        public Limousine(string manufacturer, string model, int licencePlate, bool hasMiniBar)
        {
            Manufacturer = manufacturer;
            Model = model;
            LicencePlate = licencePlate;
            HasMinibar = hasMiniBar;
            Kilometers = 0;
            RentalDate = null;
        }

        /// <summary>
        /// Rents the limousine. The limousine will be unavailable after renting. 
        /// It will be avaiable again after returning the limousine.
        /// 
        /// Only available limousines can be rented.
        /// </summary>
        /// <param name="rentalDate">The date on which the limousine is rented.</param>
        /// <returns>true if the limousine was available and renting, false otherwise.</returns>
        public bool Rent(SimpleDate rentalDate)
        {
            if (IsAvailable)
            {
                RentalDate = rentalDate;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a rented limousine and calculate the costs of the rental. 
        /// Only rented limousines can be returned.
        /// </summary>
        /// <param name="returnDate">The date on which the limousine is returned.</param>
        /// <param name="kilometers">The total number of kilometers on the counter.</param>
        /// <returns>The cost of the rental, 
        ///          or a number less than zero when: 
        ///          - the limousine was not rented (so it could not be returned)
        ///          - the return date is before the rental date (so wrong return date was entered)
        ///          - the number of kilometers when returned is less then at the start of the rental.         
        /// Please note that returning as number less than zero for error situations is NOT(!!!)
        /// clean coding in this case. Later on you will learn to do this in a better fashion (Exceptions!)
        /// </returns>
        public decimal Return(SimpleDate returnDate, int kilometers)
        {
            if (!IsAvailable)
            {
                int daysRented = RentalDate.DaysDifference(returnDate);
                int kilometersDriven = kilometers - Kilometers;

                if (daysRented >= 0 && kilometersDriven >= 0)
                {
                    RentalDate = null;    // makes the limousine available for renting again
                    Kilometers = kilometers; // update kms for the next rental
                    return CalculateRentalCosts(daysRented, kilometersDriven);
                }
            }
            return -1;
        }

        /// <summary>
        /// Calculate the price of a rental.
        /// </summary>
        /// <param name="daysRented">The number of days of the rental.</param>
        /// <param name="kilometersDriven">The number of kilometers driven during the rental period.</param>
        /// <returns>The amount of credits to pay.</returns>
        private decimal CalculateRentalCosts(int daysRented, int kilometersDriven)
        {
            const decimal dayRate = 200m;
            const decimal kmRate = 0.25m;
            decimal minibarDayRate;
            if (HasMinibar)
            {
                minibarDayRate = 20m;
            }
            else
            {
                minibarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (minibarDayRate * daysRented);
        }

        /// <summary>
        /// Retrieve information about this limousine
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing information about this limosine.</returns>
        public override string ToString()
        {
            string availableInfo;
            if (IsAvailable)
            {
                availableInfo = "available";
            }
            else
            {
                availableInfo = "not available";
            }

            string minibarInfo;
            if (HasMinibar)
            {
                minibarInfo = "with mini bar";
            }
            else
            {
                minibarInfo = "without mini bar";
            }


            return "Limousine: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + minibarInfo;
        }
    }
}
