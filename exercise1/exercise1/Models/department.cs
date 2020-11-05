using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exercise1.Models
{
    class Department: BaseEntity
    {

        public string Name { get; private set; }

        public Department(int id, string name): base(id)
        {

            Name = name;

        }

    }
}
