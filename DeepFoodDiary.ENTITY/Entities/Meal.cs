using DeepFoodDiary.ENTITY.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class Meal : BaseEntity
    {
        public string MealName { get; set; }


        //nav prop
        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }

        public Meal()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }

    }
}
