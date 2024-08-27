using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car>? GetByModelYear(int id);
        List<Car> GetCarsBrandId(int id);
        List<Car> GetCarsColorId(int id);
        void Add(Car car);
    }
}
