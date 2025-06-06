using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CarRental.Core.Common;
using System.Threading.Tasks;

namespace CarRental.Core.Logic
{
    public class CustomersManager
    {
        public BindingList<Customer> Customers { get; }

        public CustomersManager()
        {
            Customers = new BindingList<Customer>();
        }

        public void Add(Customer customer)
        {
            var existingCustomer = GetByPhoneNo(customer.PhoneNo);
            if (existingCustomer != null)
            {
                throw new CarRentalException("Ekziston nje klient tjeter me kete numer telefoni!");
            }
            Customers.Add(customer);
        }
        Customer GetByPhoneNo(string phoneNo)
        {
            foreach (var customer in Customers)
            {
                if (customer.PhoneNo == phoneNo) //check again
                    return customer;
            }
            return null;
        }
        public BindingList<Customer> GetAll()
        {
            return Customers;
        }

        public bool Remove(string phoneNo)
        {
            var customer = GetByPhoneNo(phoneNo);
            if (customer != null)
            {
                Customers.Remove(customer);
                return true;
            }
            return false;
        }
        public bool Update(Customer updatedCustomer)
        {
            var existing = GetByPhoneNo(updatedCustomer.PhoneNo);
            if (existing != null)
            {
                existing.Name = updatedCustomer.Name;
                existing.Surname = updatedCustomer.Surname;
                existing.Address = updatedCustomer.Address;
                existing.Balance = updatedCustomer.Balance;
                return true;
            }
            return false;
        }

    }
}