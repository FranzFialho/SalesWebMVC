﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMVC.Data;

namespace SalesWebMVC.Migrations
{
    [DbContext(typeof(SalesWebMVCContext))]
    [Migration("20210210223611_otherEntities")]
    partial class otherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMVC.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("SalesWebMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellersId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellersId");

                    b.ToTable("SallesRecord");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWebMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWebMVC.Models.Seller", "Sellers")
                        .WithMany("Sales")
                        .HasForeignKey("SellersId");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMVC.Models.Departamento", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}