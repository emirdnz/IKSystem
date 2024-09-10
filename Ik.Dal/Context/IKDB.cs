using Ik.entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Dal.Context
{
    public class IKDB : DbContext
    {
        public IEnumerable<object> Tasks;

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<HolidayEvent> HolidayEvents { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Log> LoggingAndMonitors { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R937SDA\\TEW_SQLEXPRESS;Database=IKDB;MultipleActiveResultSets=True;Trusted_Connection=True;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
      //      modelBuilder.Entity<User>()
      //.HasOne(u => u.Employee)
      //.WithMany(e => e.Users)
      //.HasForeignKey(u => u.EmployeeId)
      //.OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


    }
}
