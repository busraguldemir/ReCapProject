using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryDal());

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }

        
        Console.ReadLine();
    }
   
}
