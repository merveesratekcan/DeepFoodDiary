using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.SeedData;

public class MealSeedData : IEntityTypeConfiguration<Meal>
{
    public void Configure(EntityTypeBuilder<Meal> builder)
    {
        builder.HasData(
            new Meal {Id=5000 ,MealName="Breakfast"},
            new Meal {Id= 5001, MealName = "Dinner" },
            new Meal {Id= 5002, MealName = "Lunch" },
            new Meal {Id= 5003, MealName = "Snack" }


            );
    }
}
