using System;
using System.Collections.Generic;

namespace exampleDataAccess.DataAccess.Models
{
    public partial class StoreProducts
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int Quantity { get; set; }
        public int StoreProductsId { get; set; }

        public virtual Products Product { get; set; }
        public virtual Stores StoreProductsNavigation { get; set; }
    }
}
