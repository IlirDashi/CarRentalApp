using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using CarRental.Core.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRental.Core.Logic
{
    public class CarsManager
    {
        private List<Car> Cars;
        public CarsManager()
        {
            Cars = new List<Car>();
        }
        public Car GetByLicensePlate(string licensePlate)
        {
            foreach (var c in Cars)
            {
                if (c.LicensePlate == licensePlate)
                //if (string.Equals(c.LicensePlate, licensePlate,
                //StringComparison.OrdinalIgnoreCase))
                {
                    return c;
                }

            }
            return null;
        }
        public void AddCar(Car c)
        {
            var existing = GetByLicensePlate(c.LicensePlate);
            if (existing != null)
            {
                throw new CarRentalException("Ekziston nje tjeter mjet me kete targe");
            }
            Cars.Add(c);

        }

       
        //Add a method to remove a car by license plate.
        //Add a method to update car details.
        //Add a method to filter cars(by availability, category, price range, etc.).

        public bool RemoveCar(string licensePlate)
        {
            var c = GetByLicensePlate(licensePlate);
            if (c != null)
            {

                Cars.Remove(c);
                return true;
            }
            return false;
        }

        public bool UpdateCar(Car updateCar)
        {
            var existing = GetByLicensePlate(updateCar.LicensePlate);
            if(existing != null)
            {
                existing.Brand = updateCar.Brand;
                existing.Model = updateCar.Model;
                existing.BodyType = updateCar.BodyType;
                existing.Category = updateCar.Category;
                existing.CategoryId = updateCar.CategoryId;
                existing.Colour = updateCar.Colour;
                existing.Year = updateCar.Year;
                existing.Mileage = updateCar.Mileage;
                existing.FuelType = updateCar.FuelType;
                existing.Transmission = updateCar.Transmission;
                existing.RentalPricePerDay = updateCar.RentalPricePerDay;
                existing.IsAvailable = updateCar.IsAvailable;
                return true;
               
            }
            return false;
        }

        public List<Car> GetAll()
        {

            return Cars;
        }

    }
}


