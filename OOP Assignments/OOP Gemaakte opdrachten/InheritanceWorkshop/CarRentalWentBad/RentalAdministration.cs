using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    public class RentalAdministration
    {
        // Contains the collection of sedans, limousines and trucks
        private List<Car> cars = new List<Car>();

        public void Add(Car car)
        {
            if (car != null) { cars.Add(car); }
        }

        public List<Car> Cars
        {
            get { return new List<Car>(cars); }
        }
        public bool RentCar(string licencePlate, SimpleDate rentalDate)
        {
            // Try to find the car with the given licence plate. Is it a Sedan?
            Car foundCar = null;
            foreach (Car car in cars)
            {
                if (car.LicencePlate == licencePlate)
                {
                    foundCar = car;
                    break;
                }
            }

            // Was a sedan with the given licene plate found? Then try to rent it.
            if (foundCar != null)
            {
                return foundCar.Rent(rentalDate);
            }
            return false;
        }

        public decimal ReturnCar(string licencePlate, SimpleDate returnDate, int kilometers)
        {
            // Try to find the car with the given licence plate. Is it a Sedan?
            Car foundCar = null;
            foreach (Car car in cars)
            {
                if (car.LicencePlate == licencePlate)
                {
                    foundCar = car;
                    break;
                }
            }

            // Was a sedan with the given licene plate found? Then try to return it.
            if (foundCar != null)
            {
                return foundCar.Return(returnDate, kilometers);
            }


            return -1; // No Sedan nor Limousine nor Truck was found with the given licence plate. Cannot return.
        }
    }
}
