﻿using Microsoft.EntityFrameworkCore;
using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }


        public DbSet<City> Cities { get; set; }


        public DbSet<Country> Countries { get; set; }
     

        public DbSet<State> States { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("CountryId","Name").IsUnique();
            /* aca le decimos que por el indice de country solo puede haber un pais*/
            modelBuilder.Entity<City>().HasIndex("StateId", "Name").IsUnique();
            /*aca le indicamos que por un stado puede haber una cuidad*/
        }

    }
}
