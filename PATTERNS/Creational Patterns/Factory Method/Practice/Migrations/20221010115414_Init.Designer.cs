﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practice.Data;

#nullable disable

namespace Practice.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221010115414_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("Practice.Entities.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BoatCaseType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<int>("EnginePower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Road")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoadDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("Practice.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<int>("EnginePower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Road")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoadDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("Traction")
                        .HasColumnType("TEXT");

                    b.Property<int>("TransmissionCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.Property<int>("carCaseType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Practice.Entities.Motorcycle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<int>("EnginePower")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxSpeed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MotorcycleCase")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Road")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoadDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Motorcycles");
                });
#pragma warning restore 612, 618
        }
    }
}
