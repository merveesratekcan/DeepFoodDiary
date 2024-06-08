using DeepFoodDiary.ENTITY.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public byte[]? UserPicture { get; set; }
        public string SecurityCode { get; set; }

        //nav prop

        public virtual UserDetails UserDetails { get; set; }
        public virtual ICollection<UserMealFood> UserMealFoods { get; set; }

        public User()
        {
            UserMealFoods = new HashSet<UserMealFood>();
        }


    }
}
