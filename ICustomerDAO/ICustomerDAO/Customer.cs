using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomerDAO
{
    class Customer
    {
        //P.O.C.O
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Address_City { get; set; }
        public string Address_Street { get; set; }
        public string Ph_Number { get; set; }

        public override string ToString()
        {
            return $"Customer {Id} {First_Name} {Last_Name} {Age} {Address_City} {Address_Street} {Ph_Number}";
        }
    }
}
