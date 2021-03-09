﻿// <auto-generated />
using BestPractiesProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BestPracticesProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BestPracticeProject.Core.Models.Katagori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Katagori");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("BestPracticeProject.Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("InnerBarcode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("KatagoriId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stok")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KatagoriId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            KatagoriId = 1,
                            Name = "Pilot Kalem",
                            Price = 13.50m,
                            Stok = 500
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            KatagoriId = 1,
                            Name = "kursun Kalem",
                            Price = 10.50m,
                            Stok = 200
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            KatagoriId = 1,
                            Name = "defter",
                            Price = 12.50m,
                            Stok = 50
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            KatagoriId = 2,
                            Name = "kucuk defter ",
                            Price = 17.50m,
                            Stok = 500
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            KatagoriId = 2,
                            Name = "orta defter",
                            Price = 15.50m,
                            Stok = 200
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            KatagoriId = 2,
                            Name = "buyuk defter",
                            Price = 11.50m,
                            Stok = 50
                        });
                });

            modelBuilder.Entity("BestPracticeProject.Core.Models.Product", b =>
                {
                    b.HasOne("BestPracticeProject.Core.Models.Katagori", "Katagori")
                        .WithMany("Products")
                        .HasForeignKey("KatagoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Katagori");
                });

            modelBuilder.Entity("BestPracticeProject.Core.Models.Katagori", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
