using ShopCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> Category { get; }
        void CreateCar(Car car);
        void DeleteCar(int id);
        Car GetOneCar(int id);
    }
}
