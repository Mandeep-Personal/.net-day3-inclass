using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace exercise1.Models
{
    class Product : BaseEntity
    {

        public double Price { get; private set; }
        public string Description { get; set; }
        public int DepartmentId { get; private set; }
        public Department Department { get; private set; }
        public Product(int id, double price, string description, Department department): base(id)
        {

            this.Price = price;
            this.Description = description;
            this.DepartmentId = department.Id;
            this.Department = department;
    
        }

    }

}
