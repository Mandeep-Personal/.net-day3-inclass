using exercise1.Models;
using System;

namespace exercise1
{


   class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department(1, "Sales");
            Department department2 = new Department(2, "Services");

            Product unknownProd = new Product(2, 24.95, "I dunno yet", department2);

            Car car1 = new Car(1, 12345.22, "hybrid", department1, "abcd12345678", "Toyota", "Camry", 2007, 77000, false);
            Car car2 = new Car(1, 19345.22, "hybrid", department1, "abcd12345679", "Toyota", "Camry", 2010, 107000, false);
            Service service1 = new Service(1, 99.87, "Winter Ready", department2, "storm1", true, 20);


            Product[] myProds = new Product[]
            {
                unknownProd,
                service1,
                car1,
                car2

            };

            foreach(Product p in myProds)
            {
                if (p.GetType() == typeof(Car))
                {
                    Car c = (Car)p;
                    Console.WriteLine(c.Make);
                }
                else if (p.GetType() == typeof(Service))
                {
                    Service s = (Service)p;
                    Console.WriteLine(s.Name);
                }
                else
                {
                    Console.WriteLine(p.Description);
                }

            }


            Console.WriteLine($"{car1.Department.Name}: {car1.Make} {car1.Model} {car1.Price.ToString("C")}");
            Console.WriteLine($"{car2.Department.Name}: {car2.Make} {car2.Model} {car2.Price.ToString("C")}");
            Console.WriteLine($"{service1.Department.Name}: {service1.Description} {service1.EstimateHours} {service1.Price.ToString("C")}");

            Console.ReadLine();
     
        }
    }
}
