using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class MealConfiguration : BaseConfiguration<Meal>
{
    public override void Configure(EntityTypeBuilder<Meal> builder)
    {
        builder.Property(x => x.Id).UseIdentityColumn(5000, 1);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.MealName).IsRequired().HasMaxLength(40);
        
        
        base.Configure(builder);
    }
}
