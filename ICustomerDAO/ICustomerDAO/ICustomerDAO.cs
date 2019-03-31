using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomerDAO
{
   interface ICustomerDAO
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer cust);
        void UpdateCustomer(int id, Customer cust);
        void DeleteCustomer(int id, Customer cust);
        List<Customer> GetCustomerLivingCity(string city);
        List<Customer> GetCustomerBetweenAges(int minAge, int maxAge);
        Customer GetCustomerByPhoneNumber(int phone);
        void RemoveAllCustomers();

    }
}
