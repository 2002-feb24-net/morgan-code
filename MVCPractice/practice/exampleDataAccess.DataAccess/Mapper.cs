using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exampleDataAccess.DataAccess
{
    public static class Mapper
    {
        public static Domain.Models.Customers MapCustomers(Models.Customers customer)
        {
            return new Domain.Models.Customers
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Phone = customer.Phone,
                Email = customer.Email,
                Address = customer.Address,
                City = customer.City,
                State = customer.State,
                FullName = customer.FullName,
                //StoreId = customer.StoreId.Select(MapStores).ToList()

            };
        }

        public static Models.Orders MapOrders(Domain.Models.Orders order)
        {
            return new Models.Orders
            {
                OrderId = order.OrderId,
                CustomerId = order.CustomerId,
                ProductOrdersId = order.ProductOrdersId,
                StoreId = order.StoreId,
                Date = order.Date,
                Quantities = order.Quantities,
                TotalPrice = order.TotalPrice,
                //Store = order.Store.Select(MapCustomers).ToList()
                //ProductOrders = order.ProductOrders.Select(MapProductOrders).ToList()

            };
        }

        public static Models.ProductOrders MapProductOrders(Domain.Models.ProductOrders productOrder)
        {
            return new Models.ProductOrders
            {
                ProductOrderId = productOrder.ProductOrderId,
                ProductId = productOrder.ProductId,
                OrderId = productOrder.OrderId,
                Quantity = productOrder.Quantity,
                //Order = productOrder.Order.Select(MapOrders).ToList(),
                //Product = productOrder.Product.Select(MapProducts).ToList()
            };
        }

        public static Models.Products MapProducts(Domain.Models.Products product)
        {
            return new Models.Products
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Type = product.Type,
                Brand = product.Brand,
                Price = product.Price,
                Quantity = product.Quantity,
                StoreId = product.StoreId,
                ProductOrders = product.ProductOrders.Select(MapProductOrders).ToList(),
                StoreProducts = product.StoreProducts.Select(MapStoreProducts).ToList()
                

            };
        }
    }
}
