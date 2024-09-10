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
    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => p.RoleName).IsUnique();
            builder.HasData(
                new Role
                {
                    Id = 1,
                    RoleName = "Admin"
                },
                new Role
                {
                    Id = 2,
                    RoleName = "HR"
                },
                new Role
                {
                    Id = 3,
                    RoleName = "Employee"
                });

        }
    }
}
