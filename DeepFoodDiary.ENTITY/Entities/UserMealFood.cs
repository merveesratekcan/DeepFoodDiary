using DeepFoodDiary.ENTITY.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class UserMealFood : BaseEntity
    {
        public int TakenCalorie { get; set; }
        public DateTime MealEateDate { get; set; }
        public int Portion { get; set; }
        //nav prop
        public int UserID { get; set; }
        public virtual User Users { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }

        public int FoodID { get; set; }
        public virtual Food Food { get; set; }






    }
}
