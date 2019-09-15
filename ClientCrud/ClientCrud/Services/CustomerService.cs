using ClientCrud.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientCrud.Services
{
    public class CustomerService
    {
        private List<Customer> customers;
        public CustomerService()
        {
            customers = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
        public void UpdateCustomer(int customerId, Customer customer)
        {
            Customer customerFound = customers.Find(c => c.Id == customerId);

            customer.Id = customerFound.Id;
            customers.Remove(customerFound);
            customers.Add(customer);
        }
        public List<Customer> GetCustomers()
        {
            return customers;
        }
        public Customer GetCustomer(int customerId)
        {
            Customer customerFound = customers.Find(c => c.Id == customerId);

            return customerFound;
        }

    }
}
