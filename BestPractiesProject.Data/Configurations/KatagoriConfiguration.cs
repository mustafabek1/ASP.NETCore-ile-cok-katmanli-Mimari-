using BestPracticeProject.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractiesProject.Data.Confgurations
{
    class KatagoriConfiguration : IEntityTypeConfiguration<Katagori>
    {
        public void Configure(EntityTypeBuilder<Katagori> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.ToTable("Katagori");

        }
    }
}
