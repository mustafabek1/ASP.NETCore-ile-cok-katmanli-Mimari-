using BestPracticeProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesProject.Data.Configurations.Seeds
{
    class KatagoriSeed:IEntityTypeConfiguration<Katagori>
    {
        private readonly int[]_ids;

        public KatagoriSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Katagori> builder)
        {
            builder.HasData(new Katagori { Id = _ids[0], Name = "Kalemler" },
            new Katagori { Id = _ids[1], Name = "Defterler" });


        }
    }
}
