using ShopCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Data.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Order> GetAllOrders { get; }
        void SaveOrder(Order order);
        void DeleteOrder(int id);
    }
}
