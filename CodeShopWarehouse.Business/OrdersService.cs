﻿using System;
using System.Collections.Generic;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Business
{
    // Business Logic
    public class OrdersService : IOrdersService
    {
        private readonly IOrdersRepo _ordersRepo;

        public OrdersService(IOrdersRepo ordersRepo)
        {
            _ordersRepo = ordersRepo;
        }

        public List<IOrder> GetUnprocessedOrders()
        {
            return _ordersRepo.GetUnProcessedOrders();
        }

        public IOrder GetById(int id)
        {
            return _ordersRepo.GetOrderById(id);
        }
        
        public IOrder ProcessOrder(Order order)
        {
            return _ordersRepo.UpdateOrder(order);
        }

        public IOrder CreateOrder(Order order)
        {
            return _ordersRepo.CreateOrder(order);
        }
    }
}