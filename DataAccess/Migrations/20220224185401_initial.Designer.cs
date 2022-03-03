﻿// <auto-generated />
using System;
using DataAccess;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RealEstateContext))]
    [Migration("20220224185401_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Concrete.HomeProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdvertNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AgeOfApartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CarPark")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeedStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Exchange")
                        .HasColumnType("bit");

                    b.Property<string>("Facede")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FurnitureStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("Lift")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ListingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumberOfBath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Square")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarmType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhichFloor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("Entities.Concrete.LandProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdvertNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvertState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeedStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExchangeSatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ListingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Precedent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Square")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lands");
                });
#pragma warning restore 612, 618
        }
    }
}
