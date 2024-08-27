using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        
        public void Add(Car car)
        {
            if (car.Name.Length<2)
            {
                throw new Exception("Car name must be at least 2 characters long. ");
            }

            if (car.DailyPrice > 0)
            {
                throw new Exception("Car daily price must be greater than be 0. ");
            }
            _carDal.Add(car);
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car>? GetByModelYear(int year)
        {
            var cars = _carDal.GetAll(y=>y.ModelYear > year);
            return cars;
        }

        public List<Car> GetCarsBrandId(int id)
        {
            var arabalar = _carDal.GetAll(car => car.BrandId == id);
            return arabalar;
        }

      

        public List<Car> GetCarsColorId(int id)
        {
            var arabalar = _carDal.GetAll(car => car.ColorId == id);
            return arabalar;
        }
    }
}
