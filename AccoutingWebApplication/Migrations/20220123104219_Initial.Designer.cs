﻿// <auto-generated />
using System;
using AccoutingWebApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccoutingWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220123104219_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccoutingWebApplication.Domain.Models.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAddedDepartament")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateChangeInformationDepartament")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartamentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("AccoutingWebApplication.Domain.Models.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateChangeEmployee")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEmployeeAdded")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentId");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("AccoutingWebApplication.Domain.Models.Employe", b =>
                {
                    b.HasOne("AccoutingWebApplication.Domain.Models.Departament", "Departament")
                        .WithMany()
                        .HasForeignKey("DepartamentId");
                });
#pragma warning restore 612, 618
        }
    }
}