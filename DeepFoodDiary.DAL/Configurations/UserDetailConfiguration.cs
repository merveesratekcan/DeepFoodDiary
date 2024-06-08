using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class UserDetailConfiguration:BaseConfiguration<UserDetails>
{
    public override void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x=>x.FullName).IsRequired().HasMaxLength(128);
        builder.Property(x => x.Gender).IsRequired();
        builder.Property(x => x.BirthDate).IsRequired();
        builder.Property(u => u.Height)
                .IsRequired();

        builder.Property(u => u.Weight)
               .IsRequired();
        builder.Ignore(u => u.Age);
        builder.Property(x => x.TotalCalorie).IsRequired();

        builder.HasOne(u => u.User)  
                .WithOne(u => u.UserDetails)  
                .HasForeignKey<UserDetails>(u => u.UserId)  
                .OnDelete(DeleteBehavior.Restrict);
        base.Configure(builder);    
    }

}
