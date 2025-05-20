using AutomobileClibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileClibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int carId);
        void InsertNew(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
    }
}
