using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileClibrary.DataAccess
{
    public class CarManagement
    {
        private static CarManagement instance = null;
        public static readonly object instanceLock = new object();
        private CarManagement() { }
        public static CarManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarManagement();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList()
        {
            List<Car> cars;
            try
            {
                var myStockBD = new MyStockContext();
                cars = myStockBD.Cars.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cars;
        }

        public Car GetCarById(int carID)
        {
            Car car = null;
            try
            {
                var myStockBD = new MyStockContext();
                car = myStockBD.Cars.SingleOrDefault(car => car.CarId == carID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return car;
        }

        public void AddNew(Car car)
        {
            try
            {
                Car _car = GetCarById(car.CarId);
                if (_car == null)
                {
                    var myStockBD = new MyStockContext();
                    myStockBD.Cars.Add(car);
                    myStockBD.SaveChanges();
                }
                else
                {
                    throw new Exception(" The car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Car car)
        {
            try
            {
                Car c = GetCarById(car.CarId);
                if (c != null)
                {
                    var myStockDB = new MyStockContext();
                    myStockDB.Entry<Car>(car).State = EntityState.Modified;
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(Car car)
        {
            try
            {
                Car _car = GetCarById(car.CarId);
                if (_car != null)
                {
                    var myStockDB = new MyStockContext();
                    myStockDB.Cars.Remove(car);
                    myStockDB.SaveChanges();
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}

