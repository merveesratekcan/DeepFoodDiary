using DeepFoodDiary.ENTITY.BaseEntities;
using DeepFoodDiary.ENTITY.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class Food : BaseEntity
    {

        public string FoodName { get; set; }
        public double Calorie { get; set; }
        public string Protein { get; set; }
        public string Carbonhydrate { get; set; }
        public string Fat { get; set; }
        public float Measurement { get; set; }

        public byte[]? Picture { get; set; }

        public PortionType PortionType { get; set; }

        public int CategoryId { get; set; }
        //nav prop
        public virtual Category Category { get; set; }
        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }
        public Food()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }
    }
}
