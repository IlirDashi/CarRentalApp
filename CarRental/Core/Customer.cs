using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System.Xml;

namespace CarRental.Core
{
    public class Customer
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }
    }
}
