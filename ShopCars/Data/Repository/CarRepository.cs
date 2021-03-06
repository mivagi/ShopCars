using Microsoft.EntityFrameworkCore;
using ShopCars.Data.Interfaces;
using ShopCars.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCars.Data.Repository
{
    //Класс для работы с таблицей Cars в базе данных
    public class CarRepository : IAllCars
    {
        private readonly AppDbContent content;

        public CarRepository(AppDbContent content)
        {
            this.content = content;
        }
        public IEnumerable<Car> Cars => content.Cars;
        public IEnumerable<Car> Category => content.Cars.Include(p => p.Category);
        public void CreateCar(Car car)
        {
            if (car.Id == 0)
            {
                content.Cars.Add(car);
            }
            else
            {
                Car newCar = content.Cars.FirstOrDefault(p => p.Id == car.Id);
                newCar.Name = car.Name;
                newCar.Img1 = car.Img1;
                newCar.Price = car.Price;
                newCar.CategoryId = car.CategoryId;
                newCar.Category = car.Category;
            }
            content.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            Car car = content.Cars.FirstOrDefault(p => p.Id == id);
            if (car != null)
            {
                content.Cars.Remove(car);
                content.SaveChanges();
            }
        }

        public Car GetOneCar(int id)
        {
            return content.Cars.FirstOrDefault(p => p.Id == id);
        }
    }
}
