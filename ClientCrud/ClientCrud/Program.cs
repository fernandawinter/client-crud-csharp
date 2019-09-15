using ClientCrud.Model;
using ClientCrud.Services;
using System;
using System.Collections.Generic;

namespace ClientCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerService service = new CustomerService();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Fernanda";
            customer1.Age = 24;
            customer1.Cpf = "0123456787454";
            customer1.Address = "R. Felicissimo de Azevedo";

            service.AddCustomer(customer1);

            List<Customer> customers = service.GetCustomers();

            PrintCustomers(customers);

        }

        private static void PrintCustomer(Customer c)
        {
            Console.WriteLine("ID: {0} - Name: {1} - Age: {2} - CPF: {3} - Address: {4}", c.Id, c.Name, c.Age, c.Cpf, c.Address);
        }

        private static void PrintCustomers(List<Customer> customers)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                PrintCustomer(customers[i]);
            }
        }
    }
}
