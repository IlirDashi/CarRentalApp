using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model {  get; set; }
        public string BodyType {  get; set; }
        public string Colour {  get; set; }
        public int Mileage {  get; set; }
        public int Year {  get; set; }
        public decimal RentalPricePerDay {  get; set; }
        public string LicensePlate { get; set; }
        public bool IsAvailable {  get; set; }
        public string FuelType {  get; set; }
        public string Transmission {  get; set; }
        public int CategoryId {  get; set; }
        public Category Category { get; set; }


    }
}
