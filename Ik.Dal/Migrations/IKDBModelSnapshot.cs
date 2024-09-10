﻿// <auto-generated />
using System;
using Ik.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ik.Dal.Migrations
{
    [DbContext(typeof(IKDB))]
    partial class IKDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ik.entities.Concrete.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(220)
                        .HasColumnType("nvarchar(220)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 9, 10, 13, 30, 32, 62, DateTimeKind.Local).AddTicks(9778));

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("Id");

                    b.HasIndex("EmailAdress")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "TEST",
                            CompanyName = "IKTESTCOMPANY",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAdress = "info@IKtestcompany.com",
                            IsApproved = false,
                            PhoneNumber = "12345678900"
                        });
                });

            modelBuilder.Entity("Ik.entities.Concrete.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 9, 10, 13, 30, 32, 63, DateTimeKind.Local).AddTicks(1446));

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "testhr@gmail.com",
                            FirstName = "ADMİN",
                            HireDate = new DateTime(2024, 9, 10, 13, 30, 32, 63, DateTimeKind.Local).AddTicks(9484),
                            LastName = "test",
                            Position = "HR"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "testadmin@gmail.com",
                            FirstName = "HR",
                            HireDate = new DateTime(2024, 9, 10, 13, 30, 32, 63, DateTimeKind.Local).AddTicks(9487),
                            LastName = "test",
                            Position = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "testemployee@gmail.com",
                            FirstName = "EMPLOYEE",
                            HireDate = new DateTime(2024, 9, 10, 13, 30, 32, 63, DateTimeKind.Local).AddTicks(9488),
                            LastName = "test",
                            Position = "Employee"
                        });
                });

            modelBuilder.Entity("Ik.entities.Concrete.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpenseType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Ik.entities.Concrete.HolidayEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublicHoliday")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HolidayEvents");
                });

            modelBuilder.Entity("Ik.entities.Concrete.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoggingAndMonitors");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CertificationDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EducationDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("ExperienceDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 9, 10, 13, 30, 32, 64, DateTimeKind.Local).AddTicks(439));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "HR"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            RoleName = "Employee"
                        });
                });

            modelBuilder.Entity("Ik.entities.Concrete.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Ik.entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 9, 10, 13, 30, 32, 64, DateTimeKind.Local).AddTicks(1940));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CompanyName = "IKTESTCOMPANY",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@gmail.com",
                            EmployeeId = 1,
                            IsActive = false,
                            Name = "UserAdmin",
                            Password = "123",
                            RoleId = 1,
                            RoleName = "Admin",
                            SurName = "Test"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            CompanyName = "IKTESTCOMPANY",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hr@gmail.com",
                            EmployeeId = 2,
                            IsActive = false,
                            Name = "Userhr",
                            Password = "123",
                            RoleId = 2,
                            RoleName = "HR",
                            SurName = "Test"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            CompanyName = "IKTESTCOMPANY",
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "employee@gmail.com",
                            EmployeeId = 3,
                            IsActive = false,
                            Name = "Useremployee",
                            Password = "123",
                            RoleId = 3,
                            RoleName = "EMPLOYEE",
                            SurName = "Test"
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Employee", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Expense", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Employee", "Employee")
                        .WithMany("Expenses")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Ik.entities.Concrete.LeaveRequest", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Employee", "Employee")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Resume", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Ik.entities.Concrete.User", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ik.entities.Concrete.Employee", "Employee")
                        .WithMany("Users")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Ik.entities.Concrete.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ik.entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ik.entities.Concrete.Company", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Ik.entities.Concrete.Employee", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("LeaveRequests");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
