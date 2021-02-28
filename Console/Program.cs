using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(),new RulesManager());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.BrandId+"/"+car.ColorId);
            }
     

            

        }
    }
}
