using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BasicRequestLab.Models
{
    public partial class UnivModernDBContext : DbContext
    {
        public UnivModernDBContext()
        {
        }

        public UnivModernDBContext(DbContextOptions<UnivModernDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vendor> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Database=univmoderndb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>().HasData(
                                new Vendor
                                {
                                    Cnum = 1001,
                                    Sname = "Peel",
                                    City = "London",
                                    Comm = .12m
                                },
                                new Vendor
                                {
                                    Cnum = 1002,
                                    Sname = "Serres",
                                    City = "San Jose",
                                    Comm = .13m
                                },
                                new Vendor
                                {
                                    Cnum = 1004,
                                    Sname = "Motika",
                                    City = "London",
                                    Comm = .11m
                                },
                                new Vendor
                                {
                                    Cnum = 1007,
                                    Sname = "Rifkin",
                                    City = "Barcelona",
                                    Comm = .15m
                                },
                                new Vendor
                                {
                                    Cnum = 1003,
                                    Sname = "Axelrod",
                                    City = "New York",
                                    Comm = .1m
                                }
                );

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
