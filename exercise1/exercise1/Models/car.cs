using System;
using System.Collections.Generic;
using System.Text;

namespace exercise1.Models
{
    class car : BaseEntity
    {

        public string Name { get; private set; }

        public int Make { get; private set; }

        public decimal Price { get; private set; }

        public string Description { get; private set; }


    }
}
