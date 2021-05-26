using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalWentBad
{
    /// <summary>
    /// This class is full of long methods and duplications. Barf! 
    /// Can inheritance help you?
    /// BTW: This class is not the only class with duplications!
    /// </summary>
    public class RentalAdministration
    {
        // Contains the collection of sedans, limousines and trucks
        private List<Sedan> sedans;
        private List<Limousine> limousines;
        private List<Truck> trucks;

        /// <summary>
        /// The sedans in the administration
        /// </summary>
        public List<Sedan> Sedans
        {
            get { return new List<Sedan>(sedans); }
        }

        /// <summary>
        /// The limousines in the administration
        /// </summary>
        public List<Limousine> Limousines
        {
            get { return new List<Limousine>(limousines); }
        }

        /// <summary>
        /// The trucks in the administration
        /// </summary>
        public List<Truck> Trucks
        {
            get { return new List<Truck>(trucks); }
        }

        /// <summary>
        /// Creates an a rental administration.
        /// </summary>
        public RentalAdministration()
        {
            sedans = new List<Sedan>();
            limousines = new List<Limousine>();
            trucks = new List<Truck>();
        }

        /// <summary>
        /// Add a sedan to the administration
        /// </summary>
        /// <param name="sedan">The sedan to be added to the administration</param>
        public void Add(Sedan sedan)
        {
            if (sedan != null)
            {
                sedans.Add(sedan);
            }
        }

        /// <summary>
        /// Add a limousine to the administration
        /// </summary>
        /// <param name="sedan">The limousine to be added to the administration</param>
        public void Add(Limousine limousine)
        {
            if (limousine != null)
            {
                limousines.Add(limousine);
            }
        }

        /// <summary>
        /// Add a truck to the administration
        /// </summary>
        /// <param name="sedan">The truck to be added to the administration</param>
        public void Add(Truck truck)
        {
            if (truck != null)
            {
                trucks.Add(truck);
            }
        }

        /// <summary>
        /// Rent a car
        /// </summary>
        /// <param name="licencePlate">The licence plate of the car to rent</param>
        /// <param name="rentalDate">The start date for the rental</param>
        /// <returns>true if the car was available for renting, false otherwise.</returns>
        public bool RentCar(int licencePlate, SimpleDate rentalDate)
        {
            // Try to find the car with the given licence plate. Is it a Sedan?
            Sedan foundSedan = null;
            foreach (Sedan sedan in sedans)
            {
                if (sedan.LicencePlate == licencePlate)
                {
                    foundSedan = sedan;
                    break;
                }
            }

            // Was a sedan with the given licene plate found? Then try to rent it.
            if (foundSedan != null)
            {
                return foundSedan.Rent(rentalDate);
            }

            // No car found yet with the given licence plate.
            // Try to find the car with the given licence plate. Is it a Limousine?
            Limousine foundLimousine = null;
            foreach (Limousine limousine in limousines)
            {
                if (limousine.LicencePlate == licencePlate)
                {
                    foundLimousine = limousine;
                    break;
                }
            }

            // Was a limousine with the given licene plate found? Then try to rent it.
            if (foundLimousine != null)
            {
                return foundLimousine.Rent(rentalDate);
            }

            // No car found yet with the given licence plate.
            // Try to find the car with the given licence plate. Is it a Truck?
            Truck foundTruck = null;
            foreach (Truck truck in trucks)
            {
                if (truck.LicencePlate == licencePlate)
                {
                    foundTruck = truck;
                    break;
                }
            }

            // Was a truck with the given licene plate found? Then try to rent it.
            if (foundTruck != null)
            {
                return foundTruck.Rent(rentalDate);
            }

            return false; // No Sedan nor Limousine nor Truck was found with the given licence plate.
        }

        /// <summary>
        /// Return a car to the administration of available cars
        /// </summary>
        /// <param name="licencePlate">The licence plate of the car to return.</param>
        /// <param name="returnDate">The date on which the car is returned.</param>
        /// <param name="kilometers">The total of kilometers of the car.</param>
        /// <returns>The cost of the rental, 
        ///          or a number less than zero when: 
        ///          - the car was not rented (so it could not be returned)
        ///          - the return date is before the rental date (so wrong return date was entered)
        ///          - the number of kilometers when returned is less then at the start of the rental.         
        /// Please note that returning as number less than zero for error situations is NOT(!!!)
        /// clean coding in this case. Later on you will learn to do this in a better fashion (Exceptions!)
        /// </returns>
        public decimal ReturnCar(int licencePlate, SimpleDate returnDate, int kilometers)
        {
            // Try to find the car with the given licence plate. Is it a Sedan?
            Sedan foundSedan = null;
            foreach (Sedan sedan in sedans)
            {
                if (sedan.LicencePlate == licencePlate)
                {
                    foundSedan = sedan;
                    break;
                }
            }

            // Was a sedan with the given licene plate found? Then try to return it.
            if (foundSedan != null)
            {
                return foundSedan.Return(returnDate, kilometers);
            }

            // No car found yet with the given licence plate.
            // Try to find the car with the given licence plate. Is it a Limousine?
            Limousine foundLimousine = null;
            foreach (Limousine limousine in limousines)
            {
                if (limousine.LicencePlate == licencePlate)
                {
                    foundLimousine = limousine;
                    break;
                }
            }

            // Was a limousine with the given licene plate found? Then try to return it.
            if (foundLimousine != null)
            {
                return foundLimousine.Return(returnDate, kilometers);
            }

            // No car found yet with the given licence plate.
            // Try to find the car with the given licence plate. Is it a Truck?
            Truck foundTruck = null;
            foreach (Truck truck in trucks)
            {
                if (truck.LicencePlate == licencePlate)
                {
                    foundTruck = truck;
                    break;
                }
            }

            // Was a truck with the given licene plate found? Then try to return it.
            if (foundTruck != null)
            {
                return foundTruck.Return(returnDate, kilometers);
            }

            return -1; // No Sedan nor Limousine nor Truck was found with the given licence plate. Cannot return.
        }
    }
}
