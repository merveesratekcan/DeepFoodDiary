using DeepFoodDiary.ENTITY.BaseEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL.Configurations;

public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
       
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedDate).IsRequired();
        builder.Property(x => x.ModifiedDate).IsRequired(false);
        builder.Property(x => x.DeletedDate).IsRequired(false);

    }


}
