using System;
using System.Collections.Generic;
using System.Text;

namespace exampleDataAccess.Domain.Models
{
    public class Stores
    {
        public int StoreId { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public virtual StoreProducts StoreProducts { get; set; }
        public virtual List<Customers> Customers { get; set; } = new List<Customers>();
        public virtual List<Orders> Orders { get; set; } = new List<Orders>();
    }
}
