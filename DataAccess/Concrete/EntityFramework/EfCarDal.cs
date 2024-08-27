using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            using (CarRental context = new CarRental())
            {
                var addedCar = context.Entry(car);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car car)
        {
            using (CarRental context = new CarRental())
            {
                var deletedCar = context.Entry(car);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            using (CarRental context = new CarRental())
            {
               var carToDelete = context.Set<Car>().SingleOrDefault(c=> c.Id ==id);
                if (carToDelete != null)
                {
                    context.Entry(carToDelete);
                }
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRental context = new CarRental())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRental contex =new CarRental())
            {
                return filter == null? 
                contex.Set<Car>().ToList():
                contex.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetById(int id)
        {
            using (CarRental context = new CarRental())
            {
                return context.Set<Car>().SingleOrDefault(c => c.Id == id);
            }
        }


        public void Update(Car car)
        {
            using (CarRental context = new CarRental())
            {
                var updatedCar = context.Entry(car);
                updatedCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
