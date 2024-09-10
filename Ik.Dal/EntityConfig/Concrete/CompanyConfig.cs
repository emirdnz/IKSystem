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
    public class CompanyConfig : BaseConfig<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.CompanyName).IsUnicode(true);
            builder.Property(p => p.Address).HasMaxLength(220);
            builder.Property(p => p.PhoneNumber).HasMaxLength(11);
            builder.HasIndex(p => p.EmailAdress).IsUnique();


            builder.HasData(new Company
            {
                Id = 1,
                CompanyName = "IKTESTCOMPANY",
                Address = "TEST",
                PhoneNumber = "12345678900",
                EmailAdress = "info@IKtestcompany.com",
            });
        }
    }
}
