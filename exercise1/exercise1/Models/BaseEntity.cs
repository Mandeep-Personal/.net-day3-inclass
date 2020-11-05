using System;
using System.Collections.Generic;
using System.Text;

namespace exercise1.Models
{
    abstract class BaseEntity
    {
        public int Id { get; private set; }


        public BaseEntity (int id)
        {
            this.Id = id;

        }


    }
}
