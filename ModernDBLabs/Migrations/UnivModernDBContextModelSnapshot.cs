﻿// <auto-generated />
using System;
using BasicRequestLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicRequestLab.Migrations
{
    [DbContext(typeof(UnivModernDBContext))]
    partial class UnivModernDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BasicRequestLab.Models.Vendor", b =>
                {
                    b.Property<int>("Cnum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Comm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cnum");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            Cnum = 1001,
                            City = "London",
                            Comm = 0.12m,
                            Sname = "Peel"
                        },
                        new
                        {
                            Cnum = 1002,
                            City = "San Jose",
                            Comm = 0.13m,
                            Sname = "Serres"
                        },
                        new
                        {
                            Cnum = 1004,
                            City = "London",
                            Comm = 0.11m,
                            Sname = "Motika"
                        },
                        new
                        {
                            Cnum = 1007,
                            City = "Barcelona",
                            Comm = 0.15m,
                            Sname = "Rifkin"
                        },
                        new
                        {
                            Cnum = 1003,
                            City = "New York",
                            Comm = 0.1m,
                            Sname = "Axelrod"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
