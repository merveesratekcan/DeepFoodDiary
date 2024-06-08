using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class AdminConfiguration : BaseConfiguration<Admin>
{
    public override void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Id).UseIdentityColumn(100000,1);
        builder.Property(x => x.AdminName).IsRequired().HasMaxLength(128);
        builder.Property(x => x.Password).IsRequired().HasMaxLength(128);

        base.Configure(builder);
    }

}
