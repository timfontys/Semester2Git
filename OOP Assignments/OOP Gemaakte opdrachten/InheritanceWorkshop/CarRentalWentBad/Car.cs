using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
   public abstract class Car
    {
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }
        public int BuildYear { get; private set; }
        public SimpleDate RentalDate { get; set; }
        public string LicencePlate { get; private set; }
        public int Kilometers { get; set; }
        public bool IsAvailable 
        {
            get { return RentalDate == null; }
        }

        public Car(string manufacturer, string model, int buildYear, string licencePlate)
        {
            Manufacturer = manufacturer;
            Model = model;
            BuildYear = buildYear;
            LicencePlate = licencePlate;
            Kilometers = 0;
            RentalDate = null;
        }

        public bool Rent(SimpleDate rentalDate) 
        {
            if (IsAvailable)
            {
                RentalDate = rentalDate;
                return true;
            }
            return false;
        }

        public virtual decimal Return(SimpleDate returnDate, int kilometers)
        {
            if (!IsAvailable)
            {
                int daysRented = RentalDate.DaysDifference(returnDate);
                int kilometersDriven = kilometers - Kilometers;

                if (daysRented >= 0 && kilometersDriven >= 0)
                {
                    RentalDate = null;    // makes the vehicle available for renting again
                    Kilometers = kilometers; // update kms for the next rental
                    return CalculateRentalCosts(daysRented, kilometersDriven);
                }
            }
            return -1;
        }

        public abstract decimal CalculateRentalCosts(int daysRented, int kilometersDriven);

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
