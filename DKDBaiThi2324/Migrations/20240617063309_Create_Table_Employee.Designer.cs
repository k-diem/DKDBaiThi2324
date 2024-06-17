﻿// <auto-generated />
using DKDBaiThi2324.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DKDBaiThi2324.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240617063309_Create_Table_Employee")]
    partial class Create_Table_Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("DKDBaiThi2324.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DKDBaiThi2324.Models.Employee", b =>
                {
                    b.HasBaseType("DKDBaiThi2324.Models.Person");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DKDBaiThi2324.Models.Employee", b =>
                {
                    b.HasOne("DKDBaiThi2324.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DKDBaiThi2324.Models.Employee", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}