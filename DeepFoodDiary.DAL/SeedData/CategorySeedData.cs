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

public class CategorySeedData : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData
            (
             new Category { Id = 10000, CategoryName = "Vegetable", Status = Statu.Created },
             new Category { Id = 10001, CategoryName = "Fruits", Status = Statu.Created },
             new Category { Id = 10002, CategoryName = "DairyProducts", Status = Statu.Created },
             new Category { Id = 10003, CategoryName = "MeatProducts", Status = Statu.Created },
             new Category { Id = 10004, CategoryName = "FishandSeafood", Status = Statu.Created },
             new Category { Id = 10005, CategoryName = "Legumes", Status = Statu.Created },
             new Category { Id = 10006, CategoryName = "Grains", Status = Statu.Created },
             new Category { Id = 10007, CategoryName = "SugarsAndSweets", Status = Statu.Created },
             new Category { Id = 10008, CategoryName = "Beverages", Status = Statu.Created },
             new Category { Id = 10009, CategoryName = "Soups ", Status = Statu.Created },
             new Category { Id = 10010, CategoryName = "BakeryProducts", Status = Statu.Created },
             new Category { Id = 10011, CategoryName = "SpicesAndSauces", Status = Statu.Created },
             new Category { Id = 10012, CategoryName = "Snack", Status = Statu.Created },
             new Category { Id = 10013, CategoryName = "AlcoholicBeverages", Status = Statu.Created },
             new Category { Id = 10014, CategoryName = "Salad", Status = Statu.Created },
             new Category { Id = 10015, CategoryName = "Main Food", Status = Statu.Created },
             new Category { Id = 10016, CategoryName = "For Breakfast", Status = Statu.Created }
             


            );
    }

}
