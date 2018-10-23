using System.Collections.Generic;
using CodeShopWarehouse.Entities;

namespace CodeShopWarehouse.Business
{
    public interface IOrdersService
    {
        List<IOrder> GetUnprocessedOrders();
        IOrder GetById(int id);
        IOrder ProcessOrder(Order order);
        IOrder CreateOrder(Order order);
    }
}