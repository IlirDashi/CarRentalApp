using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core
{
    public class Rental
    {
        public int Id { get; set; }
        public int CustomerId {  get; set; }
        public Customer Customer { get; set; }
        public int CarId {  get; set; }
        public Car Car { get; set; }
        public DateTime RentalStart {  get; set; }
        public DateTime RentalEnd { get; set; }
        public decimal TotalPrice {  get; set; }
        public string Status {  get; set; }
    }
}
