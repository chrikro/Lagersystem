namespace Storage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Storage.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Storage.DataAcessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Storage.DataAcessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            DateTime InitTime = DateTime.Now;
            context.Products.AddOrUpdate(
                p => p.Name,
            new Product { Id = 1000, Name = "Dator", Price = 8999m, Category = "Elektronik", Shelf = "A1", Count = 54, ProductImageUrl = "/Image/dator.jpg", Description = "Stationär dator från HP", LastEdited = InitTime },
            new Product { Id = 1010, Name = "Skärm", Price = 1800m, Category = "Elektronik", Shelf = "A1", Count = 0, ProductImageUrl = "/Image/skaerm.jpg", Description = "Platt skärm 16 tum", LastEdited = InitTime },
            new Product { Id = 1100, Name = "Mus", Price = 120m, Category = "Elektronik", Shelf = "A1", Count = 154, ProductImageUrl = "/Image/mus.png", Description = "Pekdon från Logitech. USB.", LastEdited = InitTime },
            new Product { Id = 2000, Name = "Tangentbord", Price = 170m, Category = "Elektronik", Shelf = "A1", Count = 14, ProductImageUrl = "/Image/tangentbord.jpg", Description = "Med USB-Sladd", LastEdited = InitTime },
            new Product { Id = 5001, Name = "Lättmjölk", Price = 8.95m, Category = "Mat", Shelf = "M1", Count = 267, ProductImageUrl = "/Image/lettmjolk.jpg", Description = "Arla, svensk, 1.5 % fett",LastEdited = InitTime }


            );

            //
        }
    }
}
