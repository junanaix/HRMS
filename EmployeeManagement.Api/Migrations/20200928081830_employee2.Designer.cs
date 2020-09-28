﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200928081830_employee2")]
    partial class employee2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Business_Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Business_Unit");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "GS"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Payroll"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IPPR"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Business_UnitId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Business_UnitId");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BiometricID")
                        .HasColumnType("int");

                    b.Property<int?>("Business_UnitId")
                        .HasColumnType("int");

                    b.Property<string>("CurrentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marital_Status")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Business_UnitId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DivisionId");

                    b.HasIndex("SectionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BiometricID = 1,
                            CurrentAddress = "Mandug Davao City",
                            DateOfBirth = new DateTime(1985, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "robinson.chan@sonicsales.net",
                            EmployeeId = 1,
                            FirstName = "Robinson",
                            Gender = 0,
                            LastName = "Chan",
                            Marital_Status = 0,
                            PermanentAddress = "Mandug Davao City",
                            PhotoPath = "images/1.png",
                            PlaceOfBirth = "Davao City",
                            Status = 0,
                            SurName = "Jr"
                        },
                        new
                        {
                            Id = 2,
                            BiometricID = 2,
                            CurrentAddress = "Agdao Davao City",
                            DateOfBirth = new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hr@sonicsales.net",
                            EmployeeId = 2,
                            FirstName = "Nancy",
                            Gender = 1,
                            LastName = "Taypin",
                            Marital_Status = 0,
                            PermanentAddress = "General Generoso",
                            PhotoPath = "images/0.png",
                            PlaceOfBirth = "General Generoso",
                            Status = 0,
                            SurName = ""
                        },
                        new
                        {
                            Id = 3,
                            BiometricID = 3,
                            CurrentAddress = "Piapi Davao City",
                            DateOfBirth = new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "IT@sonicsales.net",
                            EmployeeId = 3,
                            FirstName = "Joseph Vincent",
                            Gender = 0,
                            LastName = "Limbaroc",
                            Marital_Status = 0,
                            PermanentAddress = "Piapi Davao City",
                            PhotoPath = "images/0.png",
                            PlaceOfBirth = "Davao City",
                            Status = 1,
                            SurName = ""
                        },
                        new
                        {
                            Id = 4,
                            BiometricID = 4,
                            CurrentAddress = "Piapi Davao City",
                            DateOfBirth = new DateTime(1992, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ofelia.bernaldez@sonicsales.net",
                            EmployeeId = 4,
                            FirstName = "Ofelia",
                            Gender = 1,
                            LastName = "Bernaldez",
                            Marital_Status = 1,
                            PermanentAddress = "Piapi Davao City",
                            PhotoPath = "images/0.png",
                            PlaceOfBirth = "Davao City",
                            Status = 0,
                            SurName = ""
                        },
                        new
                        {
                            Id = 5,
                            BiometricID = 5,
                            CurrentAddress = "Catalunan Grande Davao City",
                            DateOfBirth = new DateTime(1982, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "carol.genavia@sonicsales.net",
                            EmployeeId = 5,
                            FirstName = "Carol",
                            Gender = 1,
                            LastName = "Genavia",
                            Marital_Status = 1,
                            PermanentAddress = "Catalunan Grande Davao City",
                            PhotoPath = "images/0.png",
                            PlaceOfBirth = "Manila City",
                            Status = 0,
                            SurName = ""
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Division", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Business_Unit", "Business_Unit")
                        .WithMany()
                        .HasForeignKey("Business_UnitId");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Business_Unit", "Business_Unit")
                        .WithMany()
                        .HasForeignKey("Business_UnitId");

                    b.HasOne("EmployeeManagement.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("EmployeeManagement.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");

                    b.HasOne("EmployeeManagement.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("EmployeeManagement.Models.Section", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");
                });
#pragma warning restore 612, 618
        }
    }
}
