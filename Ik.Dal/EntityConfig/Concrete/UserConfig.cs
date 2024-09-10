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
    public class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);



            builder.HasData(new User
            {
                Id = 1,
                Name = "UserAdmin",
                SurName = "Test",
                Password = "123",
                Email = "admin@gmail.com",
                EmployeeId = 1,
                CompanyName = "IKTESTCOMPANY",
                CompanyId = 1,
                RoleId = 1,
                RoleName = "Admin",
            },
            new User
            {
                Id = 2,
                Name = "Userhr",
                SurName = "Test",
                Password = "123",
                Email = "hr@gmail.com",
                EmployeeId = 2,
                CompanyName = "IKTESTCOMPANY",
                CompanyId = 1,
                RoleName = "HR",
                RoleId = 2

            },
            new User
            {
                Id = 3,
                Name = "Useremployee",
                SurName = "Test",
                Password = "123",
                Email = "employee@gmail.com",
                EmployeeId = 3,
                CompanyName = "IKTESTCOMPANY",
                CompanyId = 1,
                RoleName = "EMPLOYEE",
                RoleId = 3,
            }
            );
        }
    }
}
