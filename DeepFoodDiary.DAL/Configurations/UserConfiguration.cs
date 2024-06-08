using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class UserConfiguration:BaseConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id).UseIdentityColumn(50000, 1);
        builder.HasKey(x => x.Id);
        builder.Property(x=> x.UserName).IsRequired().HasMaxLength(128);
        builder.Property(x=> x.Password).IsRequired().HasMaxLength(128);
        builder.Property(x=> x.SecurityCode).IsRequired().HasMaxLength(6);
        builder.Property(x => x.UserPicture).IsRequired(false);
        
        



        base.Configure(builder);
    }
}
