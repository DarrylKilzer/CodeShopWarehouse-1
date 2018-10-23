using System.Collections.Generic;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Data
 {
     public interface IOrdersRepo 
     {
         Order GetOrderById(int id);
         Order UpdateOrder(Order o);
         Order CreateOrder(Order data);
         List<Order> GetUnProcessedOrders();
         List<Order> GetOrdersByProductId(int productId);
     }
 }