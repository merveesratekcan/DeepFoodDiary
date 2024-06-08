using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class FoodConfiguration:BaseConfiguration<Food>
{
    public override void Configure(EntityTypeBuilder<Food> builder)
    {
        builder.Property(x => x.Id).UseIdentityColumn(1, 1);
        builder.Property(x=> x.FoodName).IsRequired().HasMaxLength(50);
        builder.HasIndex(x => x.FoodName).IsUnique();
        builder.Property(x => x.Calorie).IsRequired();
        builder.Property(x => x.Protein).IsRequired();
        builder.Property(x => x.Carbonhydrate).IsRequired();
        builder.Property(x => x.Fat).IsRequired();
        builder.Property(x => x.Picture).IsRequired(false);
        builder.Property(x => x.Measurement).IsRequired();
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Category).WithMany(x => x.Foods).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
       
        



        base.Configure(builder);
    }
}
