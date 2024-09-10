using Ik.Dal.EntityConfig.Abstract;
using Ik.entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Dal.EntityConfig.Concrete
{
    public class EmployeeConfig : BaseConfig<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.PhoneNumber).IsUnique();

            builder.HasData(new Employee
            {
                Id = 1,
                FirstName = "ADMİN",
                LastName = "test",
                Email = "testhr@gmail.com",
                HireDate = DateTime.Now,
                Position = "HR",
                CompanyId = 1,
            },
            new Employee
            {
                Id = 2,
                FirstName = "HR",
                LastName = "test",
                Email = "testadmin@gmail.com",
                HireDate = DateTime.Now,
                Position = "Admin",
                CompanyId = 1,
            },
            new Employee
            {
                Id = 3,
                FirstName = "EMPLOYEE",
                LastName = "test",
                Email = "testemployee@gmail.com",
                HireDate = DateTime.Now,
                Position = "Employee",
                CompanyId = 1,
            }
            );
        }

    }
}
