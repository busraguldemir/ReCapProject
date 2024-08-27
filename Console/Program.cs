using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        ICarDal carDal = new EfCarDal(); 
        ICarService carService = new CarManager(carDal);

        try
        {
            Car newCar = new Car
            {
                Name = "F",
                DailyPrice = 0
            };
            carService.Add(newCar);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        try
        {
            Car newCar = new Car
            {
                Name = "Fiat",
                DailyPrice = 100
            };
            carService.Add(newCar);
            Console.WriteLine("Car added successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }


    
    }
   
