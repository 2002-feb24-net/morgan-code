using System;
using System.Collections.Generic;
using System.Text;

namespace exampleDataAccess.Domain.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductOrdersId { get; set; }
        public int StoreId { get; set; }
        public DateTime? Date { get; set; }
        public int? Quantities { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Stores Store { get; set; }
        public virtual List<ProductOrders> ProductOrders { get; set; } = new List<ProductOrders>();
    }
}
