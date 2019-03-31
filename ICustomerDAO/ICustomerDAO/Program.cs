using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomerDAO
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDAO custDAO = new CustomerDAO();
            List<Customer> customers = custDAO.GetAllCustomers();
            Customer cust = new Customer()
            {
                Id = 1,
                First_Name = "Iliya",
                Last_Name = "Tsvibel",
                Age = 39,
                Address_City = "Rishon",
                Address_Street = "Street",

            };
            custDAO.AddCustomer(cust);

                Console.WriteLine();
            
        }
    }
}
