using Food_delivery.Models;
using Project.domain.Services;
using Project.EntityFramework;
using Project.EntityFramework.Services;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<Customer> userService = new GenericDataServices<Customer>(new Food_deliveryDbContextFactory());
            userService.Create(new Customer { Full_name="Хлопец"}).Wait();
        }
    }
}
