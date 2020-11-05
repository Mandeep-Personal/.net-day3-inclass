using System;
using System.Collections.Generic;
using System.Text;

namespace exercise1.Models
{
    class Car : Product
    {

        public string Vin { get; private set; }

        public string Make { get; private set; }

        public string Model { get; private set; }

        public int Year { get; private set; }

        public int Odometer { get; private set; }

        public bool IsNew { get; private set; }

        public Car(
            int Id, 
            double price, 
            string description, 
            Department department,
            string vin,
            string make,
            string model,
            int year,
            int odometer,
            bool isNew) : base(Id, price, description,department)
        {

            this.Vin = vin;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Odometer = odometer;
            this.IsNew = isNew;

        }
    }
}
