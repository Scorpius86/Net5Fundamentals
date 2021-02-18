using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using Net5.AttributesAndClasses.ConsoleClass.Repositories;
using Net5.AttributesAndClasses.ConsoleClass.Runners;
using System;
using System.Collections.Generic;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    class Program
    {
        public delegate void MyDelegate(int i);

        static void Main(string[] args)
        {
            ProcessPearson processPearson = new ProcessPearson();
            
            IPerson person = new Person() { Name = "Erick"};
            

            person.Run();

            StaticPerson.Run();

            processPearson.ProcessNameWithoutReference(person);

            Console.WriteLine(person.Name);

            RunDelegate(new MyDelegate(processPearson.MyMethodOne),2);
            RunDelegate(new MyDelegate(processPearson.MyMethodTwo), 33);

            person = new Humman();
            person.Run();


            //ProductRespository productRespository = new ProductRespository();

            GenericRespository<Product> productRespository = new GenericRespository<Product>();
            productRespository.Insert(new Product {ProductId = 1,Description="Teclado" });

            Product mouse = new Product { ProductId = 2, Description = "Mouse" };
            productRespository.Insert(mouse);

            Product monitor = new Product { ProductId = 3, Description = "Monitor" };
            productRespository.Insert(monitor);

            productRespository.Update(monitor, new Product { ProductId = 3, Description = "Monitor V2" });
            productRespository.Delete(mouse);

            List<Product> products = productRespository.List();

            GenericRespository<Customer> customerRespository = new GenericRespository<Customer>();
            Customer customer = new Customer { CustomerId = 1, Name = "Erick", Lastname = "Aróstegui" };
            customerRespository.Insert(customer);
            List<Customer> customers = customerRespository.List();

            GenericRespository<Sale> saleRespository = new GenericRespository<Sale>();
            Sale sale = new Sale { Id = 1, Description = "Venta de Laptop", Total = 2500 };
            saleRespository.Insert(sale);
            List<Sale> sales = saleRespository.List();

            saleRespository.DoWork<Customer>(sale, customer);

            ProductRunnerService productRunnerService = new ProductRunnerService();
            productRunnerService.Run();

            CustomerRunnerService customerRunnerService = new CustomerRunnerService();
            customerRunnerService.Run();

        }

        static public void RunDelegate(MyDelegate myDelegate,int i)
        {
            myDelegate(i);
        }
    }
}
