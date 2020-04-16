using System;
using System.Collections.Generic;
using System.Text;

namespace exampleDataAccess.Domain.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public int? StoreId { get; set; }

        public virtual List<ProductOrders> ProductOrders { get; set; } = new List<ProductOrders>();
        public virtual List<StoreProducts> StoreProducts { get; set; } = new List<StoreProducts>();
    }
}
