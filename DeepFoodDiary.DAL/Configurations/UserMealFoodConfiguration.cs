using DeepFoodDiary.ENTITY.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class UserMealFoodConfiguration:BaseConfiguration<UserMealFood>
{
    public override void Configure(EntityTypeBuilder<UserMealFood> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.Users).WithMany(x => x.UserMealFoods).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Cascade);
        


        base.Configure(builder);
    }


}
