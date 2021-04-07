using ShopCars.Data.Interfaces;
using ShopCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Data.Mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{Name = "Tesla", Price = 2000000, Img1 = "/img/tesla.jpg"},
                    new Car{Name = "Mercedes", Price = 2200000, Img1 = "/img/mercedes.jpg"}
                };
            }
        }

        public IEnumerable<Car> Category => throw new NotImplementedException();

        public void CreateCar(Car car)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetOneCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
