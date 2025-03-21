﻿// <auto-generated />
using System;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(new DateTime(2023, 5, 19, 1, 56, 55, 473, DateTimeKind.Local).AddTicks(9891));

                    b.Property<bool>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IdentityCardNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("PortraitUrl")
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Employees", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
