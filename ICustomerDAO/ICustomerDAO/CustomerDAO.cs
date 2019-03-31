using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICustomerDAO
{
    class CustomerDAO : ICustomerDAO
    {
        public void AddCustomer(Customer cust)
        {
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO Customer VALUES({cust.Id},'{cust.First_Name}','{cust.Last_Name}',{cust.Age},'{cust.Address_City}','{cust.Address_Street}','{cust.Ph_Number}')", con))
                {
                    cmd.ExecuteNonQuery();

                }


            }

        }

        public void DeleteCustomer(int id, Customer cust)
        {

            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand($"DELETE INTO Customer VALUES({cust.Id},'{cust.First_Name}','{cust.Last_Name}',{cust.Age},'{cust.Address_City}','{cust.Address_Street}','{cust.Ph_Number}')", con))
                {
                    cmd.ExecuteNonQuery();

                }


            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From Customer", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read() == true)
                        {

                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                First_Name = (string)reader["FITST_NAME"],
                                Last_Name = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                Address_City = (string)reader["ADDRESS_CITY"],
                                Address_Street = (string)reader["ADDRESS_STREET"],
                                Ph_Number = (string)reader["PH_NUMBER"]
                            };

                            customers.Add(c);

                            // pull out the data result using GetValue for dield number
                            //Console.WriteLine(
                            //$"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }


            }
            return customers;
        }


        public List<Customer> GetCustomerBetweenAges(int minAge, int maxAge)
        {
            List<Customer> customers = new List<Customer>();

            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From Customer WHERE AGE > {minAge} AND AGE < {maxAge}", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read() == true)
                        {

                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                First_Name = (string)reader["FITST_NAME"],
                                Last_Name = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                Address_City = (string)reader["ADDRESS_CITY"],
                                Address_Street = (string)reader["ADDRESS_STREET"],
                                Ph_Number = (string)reader["PH_NUMBER"]
                            };

                            customers.Add(c);

                            // pull out the data result using GetValue for dield number
                            //Console.WriteLine(
                            //$"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }


            }
            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From Customer WHERE ID = {id}", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read() == true)
                        {

                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                First_Name = (string)reader["FITST_NAME"],
                                Last_Name = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                Address_City = (string)reader["ADDRESS_CITY"],
                                Address_Street = (string)reader["ADDRESS_STREET"],
                                Ph_Number = (string)reader["PH_NUMBER"]
                            };
                            return c;

                       

                            // pull out the data result using GetValue for dield number
                            //Console.WriteLine(
                            //$"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }


            }
            return null;
        }

        public Customer GetCustomerByPhoneNumber(int phone)
        {
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From Customer WHERE PH_NUMBER = {phone}", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read() == true)
                        {

                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                First_Name = (string)reader["FITST_NAME"],
                                Last_Name = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                Address_City = (string)reader["ADDRESS_CITY"],
                                Address_Street = (string)reader["ADDRESS_STREET"],
                                Ph_Number = (string)reader["PH_NUMBER"]
                            };
                            return c;



                            // pull out the data result using GetValue for dield number
                            //Console.WriteLine(
                            //$"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }


            }
            return null;
        }

        public List<Customer> GetCustomerLivingCity(string city)
        {
            List<Customer> customers = new List<Customer>();

            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From Customer WHERE ADDRESS_CITY = {city}", con))
                {

                    // execut4e the query into the reader
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        // use the reader to read all of the results of the query
                        while (reader.Read() == true)
                        {

                            Customer c = new Customer
                            {
                                Id = (int)reader["ID"],
                                First_Name = (string)reader["FITST_NAME"],
                                Last_Name = (string)reader["LAST_NAME"],
                                Age = (int)reader["AGE"],
                                Address_City = (string)reader["ADDRESS_CITY"],
                                Address_Street = (string)reader["ADDRESS_STREET"],
                                Ph_Number = (string)reader["PH_NUMBER"]
                            };

                            customers.Add(c);

                            // pull out the data result using GetValue for dield number
                            //Console.WriteLine(
                            //$"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                        }
                    }

                }


            }
            return customers;
        }

        public void RemoveAllCustomers()
        {
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE * From Customer ", con))
                {
                    cmd.ExecuteNonQuery();

                }


            }


            
        }
        public void UpdateCustomer(int id, Customer cust)
        {
            // connect to the Data Base
            using (SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\HWdb_29.03.2019.db; Version = 3;"))
            {

                // open the connection
                con.Open();

                // create a query (suign the connection)
                using (SQLiteCommand cmd = new SQLiteCommand($"UPDATE INTO Customer VALUES({cust.Id},'{cust.First_Name}','{cust.Last_Name}',{cust.Age},'{cust.Address_City}','{cust.Address_Street}','{cust.Ph_Number}')", con))
                {
                    cmd.ExecuteNonQuery();

                }


            }
        }
    }
}

