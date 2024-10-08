﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {

        List<Car> _inMemory;
        public InMemoryDal()
        {
            _inMemory = new List<Car>()
            {
                new Car{Id=1,BrandId=1,ColorId=3, DailyPrice=15.90, ModelYear=2000,Description="Araba1"},
                new Car{Id=2,BrandId=2,ColorId=9, DailyPrice=15.50, ModelYear=2005,Description="Araba2"},
                new Car{Id=3,BrandId=3,ColorId=5, DailyPrice=11.50, ModelYear=2005,Description="Araba3"},
                new Car{Id=4,BrandId=4,ColorId=2, DailyPrice=10.50, ModelYear=2004,Description="Araba4"},
                new Car{Id=5,BrandId=5,ColorId=6, DailyPrice=19.50, ModelYear=2003,Description="Araba5"}
            };
        }

        public void Add(Car car)
        {
           _inMemory.Add(car);
        }

        public void Delete(Car car)
        {
            _inMemory.Remove(car);
        }

        public void DeleteById(int id)
        {
            var carToDelete = _inMemory.SingleOrDefault(car => car.Id == id);
            _inMemory.Remove(carToDelete);
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            var carList = _inMemory.ToList();
            return carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            var car = _inMemory.SingleOrDefault(busra => busra.Id == id);
            return car;
            
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _inMemory.SingleOrDefault(c  => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
