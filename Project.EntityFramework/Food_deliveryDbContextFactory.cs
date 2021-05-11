using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EntityFramework
{
    public class Food_deliveryDbContextFactory : IDesignTimeDbContextFactory<Food_deliveryDbContext>
    {
        public Food_deliveryDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<Food_deliveryDbContext>();
            options.UseSqlServer("Server=VADIM\\MSSQLSERVER_VADI;DataBase=Food_delivery;Trusted_Connection=True;");
            return new Food_deliveryDbContext(options.Options);
        }
    }
}
