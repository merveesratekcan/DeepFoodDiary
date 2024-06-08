using DeepFoodDiary.ENTITY.BaseEntities;
using DeepFoodDiary.ENTITY.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.ENTITY.Entities
{
    public class UserDetails : BaseEntity
    {
        public UserDetails()
        {
            Age = DateTime.Now.Year - BirthDate.Year;

        }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        [NotMapped]
        public int Age { get; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public float TotalCalorie { get; set; }

        //nav prop
        public int UserId { get; set; }
        public virtual User User { get; set; }




    }
}
