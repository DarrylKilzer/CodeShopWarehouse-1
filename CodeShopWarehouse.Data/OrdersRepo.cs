using System;
using System.Collections.Generic;
using System.Data;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Data
{
    public class OrdersRepo : IOrdersRepo
    {
        // This is where I'd put my database... IF I HAD ONE!!!
        private readonly IDbConnection _db;
        
        public OrdersRepo(IDbConnection db)
        {
            _db = db;
        }
        public Order GetOrderById(int id)
        {
            return new Order()
            {
                Id = id,
                OrderType = OrderEnum.Add,
                Processed = false,
                ProductId = Guid.NewGuid().ToString(),
                ProductStock = 20
            };
        }

        public Order UpdateOrder(Order o)
        {
            return new Order()
            {
                Id = o.Id,
                OrderType = o.OrderType,
                Processed = o.Processed,
                ProductId = Guid.NewGuid().ToString(),
                ProductStock = o.ProductStock 
            }; 
        }

        public Order CreateOrder(Order data)
        {
            return new Order()
            {
                Id = data.Id,
                OrderType = data.OrderType,
                Processed = false,
                ProductId = Guid.NewGuid().ToString(),
                ProductStock = data.ProductStock 
            }; 
        }

        public List<Order> GetUnProcessedOrders()
        {
            var orderList = new List<Order>();
            for (int i = 0; i < 20; i++)
            {
                orderList.Add(GetOrderById(i));
            }

            return orderList;
        }

        public List<Order> GetOrdersByProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
}