using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.ENTITY.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.SeedData;

public class AdminSeedData : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasData


            (
             new Admin {Id= 100000, AdminName="fooddiary",Password="123456",Status=Statu.Created}

            );
    }

}
