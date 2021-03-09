using BestPracticeProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesProject.Data.Configurations.Seeds
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;



        public ProductSeed(int[]ids)
        {
            _ids = ids;
        }
     

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(

                new Product { Id = 1, Name = "Pilot Kalem", Price = 13.50m, Stok = 500, KatagoriId = _ids[0] },
                new Product { Id = 2, Name = "kursun Kalem", Price = 10.50m, Stok = 200, KatagoriId = _ids[0] },
                new Product { Id = 3, Name = "defter", Price = 12.50m, Stok = 50, KatagoriId = _ids[0] },
                new Product { Id = 4, Name = "kucuk defter ", Price = 17.50m, Stok = 500, KatagoriId = _ids[1] },
                new Product { Id = 5, Name = "orta defter", Price = 15.50m, Stok = 200, KatagoriId = _ids[1] },
                new Product { Id = 6, Name = "buyuk defter", Price = 11.50m, Stok = 50, KatagoriId = _ids[1] }

                ) ;
            
        }
    }
}
