using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Logic
{
    public class RentalsManager
    {
        private BindingList<Rental> Rentals;
        private int idCustomer = 1;

        public RentalsManager()
        {
            Rentals = new BindingList<Rental>();
        }

    }
}
