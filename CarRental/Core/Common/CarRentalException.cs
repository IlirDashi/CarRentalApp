using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.Common
{
    public class CarRentalException : Exception
    {
        public CarRentalException(string message) : base(message)
        {

        }
    }
}
