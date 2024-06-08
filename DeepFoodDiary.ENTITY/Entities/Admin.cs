using DeepFoodDiary.ENTITY.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class Admin:BaseEntity
    {
        public string Password { get; set; } 

        public string AdminName { get; set; }



    }
}
