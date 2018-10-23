using System;
using System.Collections.Generic;
using System.Data;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Data
{
    public class OrdersRepo : IOrdersRepo
    {
        // This is where I'd put my database... IF I HAD ONE!!!
        public IOrder GetOrderById(int id)
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

        public IOrder UpdateOrder(IOrder o)
        {
            return new Order()
            {
                Id = o.Id,
                OrderType = o.OrderType,
                Processed = o.Processed,
                ProductId = Guid.NewGuid().ToString(),
                ProcessedDate = DateTimeOffset.Now,
                ProductStock = o.ProductStock 
            }; 
        }

        public IOrder CreateOrder(IOrder data)
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

        public List<IOrder> GetUnProcessedOrders()
        {
            var orderList = new List<IOrder>();
            for (int i = 0; i < 20; i++)
            {
                orderList.Add(GetOrderById(i));
            }

            return orderList;
        }

        public List<IOrder> GetOrdersByProductId(int productId)
        {
            throw new NotImplementedException();
        }
    }
}