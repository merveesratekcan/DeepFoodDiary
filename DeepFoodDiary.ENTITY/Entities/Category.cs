using DeepFoodDiary.ENTITY.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class Category : BaseEntity
    {
        public string? CategoryName { get; set; }


        //nav prop
        public virtual ICollection<Food> Foods { get; set; }
        public Category()
        {
            Foods = new HashSet<Food>();
        }
    }
}
