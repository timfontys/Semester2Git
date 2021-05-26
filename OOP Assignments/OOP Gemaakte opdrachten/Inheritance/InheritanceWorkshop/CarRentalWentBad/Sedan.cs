using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class Sedan
    {
        /// <summary>
        /// The manufacturer of the sedan
        /// </summary>
        public string Manufacturer { get; private set; }

        /// <summary>
        /// The model of the sedan
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// The licence plate of the sedan
        /// </summary>
        public int LicencePlate { get; private set; }

        /// <summary>
        /// The total number of kilometers the sedan has driven.
        /// </summary>
        public int Kilometers { get; private set; }

        /// <summary>
        /// Sedan availability for rental 
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
        /// Does the sedan have a towbar?
        /// </summary>
        public bool HasTowbar { get; private set; }

        /// <summary>
        /// Creates a sedan
        /// </summary>
        /// <param name="manufacturer">The manufacturer of the sedan</param>
        /// <param name="model">The model of the sedan</param>
        /// <param name="licencePlate">The licence plate</param>
        /// <param name="hasTowbar">Does the sedan have a towbar for towing.</param>
        public Sedan(string manufacturer, string model, int licencePlate, bool hasTowBar)
        {
            Manufacturer = manufacturer;
            Model = model;
            LicencePlate = licencePlate;
            HasTowbar = hasTowBar;
            Kilometers = 0;
            RentalDate = null;
        }

        /// <summary>
        /// Rents the sedan. The sedan will be unavailable after renting. 
        /// It will be avaiable again after returning the sedan.
        /// 
        /// Only available sedans can be rented.
        /// </summary>
        /// <param name="rentalDate">The date on which the sedan is rented.</param>
        /// <returns>true if the sedan was available and renting, false otherwise.</returns>
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
        /// Returns a rented sedan and calculate the costs of the rental. 
        /// Only rented sedans can be returned.
        /// </summary>
        /// <param name="returnDate">The date on which the sedan is returned.</param>
        /// <param name="kilometers">The total number of kilometers on the counter.</param>
        /// <returns>The cost of the rental, 
        ///          or a number less than zero when: 
        ///          - the sedan was not rented (so it could not be returned)
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
                    RentalDate = null;    // makes the sedan available for renting again
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
            const decimal dayRate = 80m;
            const decimal kmRate = 0.19m;
            decimal towbarDayRate;
            if (HasTowbar)
            {
                towbarDayRate = 5m;
            }
            else
            {
                towbarDayRate = 0m;
            }

            return (dayRate * daysRented) + (kilometersDriven * kmRate)
                + (towbarDayRate * daysRented);
        }

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

            string towbarInfo;
            if (HasTowbar)
            {
                towbarInfo = "with towbar";
            }
            else
            {
                towbarInfo = "without towbar";
            }


            return "Sedan: "
                + LicencePlate
                + ", " + availableInfo
                + ", " + Manufacturer
                + ", " + Model
                + ", " + Kilometers
                + ", " + towbarInfo;
        }
    }
}
