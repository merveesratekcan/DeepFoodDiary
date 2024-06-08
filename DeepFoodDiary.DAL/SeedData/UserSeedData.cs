using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.SeedData;

public class UserSeedData : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData
            (new User { Id = 50000, UserName = "mervesratekcan@gmail.com", Password = "123.MErve**", SecurityCode = "070424", Status = ENTITY.Enums.Statu.Created },
            new User { Id = 50001, UserName = "alikeremkaya@gmail.com", Password = "123.KErem**", SecurityCode = "070794", Status = ENTITY.Enums.Statu.Created },
            new User { Id = 50002, UserName = "musayasirkece@gmail.com", Password = "123.MUsa**", SecurityCode = "112233", Status = ENTITY.Enums.Statu.Created }


            );

    }

}
