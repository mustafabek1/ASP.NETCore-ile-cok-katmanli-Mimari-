using BestPracticeProject.Core.Models;
using BestPractiesProject.Data.Confgurations;
using BestPractiesProject.Data.Configurations.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesProject.Data
{
  public class AppDbContext: DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext>option): base
            (option)
        {

        }


        public DbSet<Katagori> Katagoris  { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiugration());
            modelBuilder.ApplyConfiguration(new KatagoriConfiguration());

            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new KatagoriSeed(new int[] { 1, 2 }));


         
        }
    }
}
