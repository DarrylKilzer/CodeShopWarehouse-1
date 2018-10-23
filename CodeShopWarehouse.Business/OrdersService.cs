using System;
using System.Collections.Generic;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Business
{
    // Business Logic
    public class OrdersService
    {
        private readonly OrdersRepo _ordersRepo;

        public OrdersService(OrdersRepo ordersRepo)
        {
            _ordersRepo = ordersRepo;
        }

        public List<Order> GetUnprocessedOrders()
        {
            return _ordersRepo.GetUnProcessedOrders();
        }

        public Order GetById(int id)
        {
            return _ordersRepo.GetOrderById(id);
        }
        
        public Order ProcessOrder(Order order)
        {
            return _ordersRepo.UpdateOrder(order);
        }
    }
}