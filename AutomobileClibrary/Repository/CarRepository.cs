using AutomobileClibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileClibrary.Repository;

namespace AutomobileClibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarById(int carId) => CarManagement.Instance.GetCarById(carId);

        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();
        public void DeleteCar(Car car) => CarManagement.Instance.Remove(car);

        public void UpdateCar(Car car) => CarManagement.Instance.Update(car);

        public void InsertNew(Car car) => CarManagement.Instance.AddNew(car);

    }
}
