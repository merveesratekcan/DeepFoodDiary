using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.SeedData;

public class UserDetailSeedData : IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {
        builder.HasData(
            new UserDetails  {UserId= 50000, Id= 1, FullName="Merve Esra Tekcan",Gender=true,Height=170,Weight=68,BirthDate=new DateTime(1993,1,7),TotalCalorie=1543,Status=ENTITY.Enums.Statu.Created},
            new UserDetails { UserId = 50001, Id = 2, FullName = "Ali Kerem Kaya", Gender = false, Height = 175, Weight = 76, BirthDate = new DateTime(1994,7,7), TotalCalorie = 2400, Status = ENTITY.Enums.Statu.Created },
            new UserDetails { UserId = 50002, Id = 3, FullName = "Musa Yasir Keçe", Gender = false, Height = 180, Weight = 74, BirthDate = new DateTime(1995,5,13), TotalCalorie = 2700, Status = ENTITY.Enums.Statu.Created }

            );
    }
}
