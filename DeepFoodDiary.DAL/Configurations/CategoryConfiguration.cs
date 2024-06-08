using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class CategoryConfiguration:BaseConfiguration<Category>
{
    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x => x.Id).UseIdentityColumn(10000, 1);
        builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(128);
        builder.HasIndex(x => x.CategoryName).IsUnique();
        
        base.Configure(builder);    
    }

}
