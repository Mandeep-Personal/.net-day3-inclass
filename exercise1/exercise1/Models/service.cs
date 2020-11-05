using System;
using System.Collections.Generic;
using System.Text;

namespace exercise1.Models
{
    class Service : Product
    {

        public string Name { get; private set; }

        public bool IsHourly { get; private set; }

        public double EstimateHours { get; set; }

        public Service(
            int id,
            double price,
            string description,
            Department department,
            string name,
            bool isHourly,
            double estimateHours) : base(id, price, description, department)
        {
            this.Name = name;
            this.IsHourly = isHourly;
            this.EstimateHours = estimateHours;
        }


    }
}
