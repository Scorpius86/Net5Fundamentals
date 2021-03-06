using System;
using System.Collections.Generic;

namespace Net5.Fundamentals.Data.ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            List<Customer> customers = new List<Customer>();
            customers = data.ListCustomers();

            Console.WriteLine("CustomerCode | CustomerName | CustomerAddress       | Dis | S | Dni      | Ruc         | Telehone  | Mobile   ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            customers.ForEach(customer =>
            {
            Console.WriteLine($"{customer.CustomerCode.PadRight(12,' ')} | {customer.CustomerName.PadRight(12,' ')} | {customer.CustomerAddress.PadRight(21,' ')} | {customer.District.PadRight(3,' ')} | {customer.Sex.PadRight(1,' ')} | {customer.Dni.ToString().PadRight(8,' ')} | {customer.Ruc.PadRight(11,' ')} | {customer.Telehone.ToString().PadRight(9,' ')} | {customer.Mobile.ToString().PadRight(9,' ')}");
            });
        }
    }
}
