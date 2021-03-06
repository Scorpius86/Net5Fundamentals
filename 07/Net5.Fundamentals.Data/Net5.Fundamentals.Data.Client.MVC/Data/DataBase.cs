using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.Fundamentals.Data.Client.MVC.Data
{
    public class DataBase
    {
        public List<Customer> ListCustomers()
        {
            List<Customer> customers = new List<Customer>();

            string strConn = "Data Source=.;Initial Catalog=Pharmacy;User ID=sa;Password=Password1234";
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string querySql = "SELECT CustomerCode,CustomerName,CustomerAddress,District,Sex,Dni,Ruc,Telehone,Mobile FROM Customer;";
                using (SqlCommand cmd = new SqlCommand(querySql, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            Customer customer = new Customer();
                            
                            customer.CustomerCode = reader.GetString(0);
                            customer.CustomerName = reader.GetString(1);
                            customer.CustomerAddress = reader.GetString(2);
                            customer.District = reader.GetString(3);
                            customer.Sex = reader.GetString(4);
                            customer.Dni = reader.GetInt32(5);
                            customer.Ruc = reader.GetString(6);
                            customer.Telehone = reader.GetInt32(7);
                            customer.Mobile = reader.GetInt32(8);

                            customers.Add(customer);
                        }
                    }

                    reader.Close();
                    conn.Close();
                }
            }

            return customers;
        }
    }
}
