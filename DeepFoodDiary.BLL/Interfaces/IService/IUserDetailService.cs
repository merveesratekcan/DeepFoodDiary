using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService
{
    public interface IUserDetailService
    {
        bool Add(UserDetails userDetails);
        bool Update(UserDetails userDetails);
        bool Delete(int userDetailsID);
        UserDetails GetById(int userDetailsID);
        List<UserDetails> GetAll();
        double DailyCaloriesNeed(int age , int height,int weight, bool gender);

        

    }
}
