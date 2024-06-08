using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.DAL;
using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Services
{
    public class UserDetailService : IUserDetailService
    {
        public bool Add(UserDetails userDetails)
        {
            if (userDetails != null)
            {
                var result = UnitOfWork.Instance.UserDetailRepository.Add(userDetails);
                if (result != null)
                {
                    return true;

                }
                return false;
            }
            return false;
        }

        public double DailyCaloriesNeed(int age, int height, int weight, bool gender)
        {

            double manCaloriesNeed = 66.47 + (13.75 * weight) + (5 * height) - (6.76 * age);
            double womanCaloriesNeed = 655.10 + (9.56 * weight) + (1.85 * height) - (4.68 * age);

            double totalCalories = 0;

            if (gender == false)
            {
                totalCalories = manCaloriesNeed;
            }
            else
            {
                totalCalories = womanCaloriesNeed;
            }

            return totalCalories;
        }

        public bool Delete(int userDetailsID)
        {
            if (userDetailsID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserDetailRepository.Delete(userDetailsID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<UserDetails> GetAll()
        {
            return UnitOfWork.Instance.UserDetailRepository.GetAll();
        }

        public UserDetails GetById(int userDetailsID)
        {
            if (userDetailsID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.UserDetailRepository.GetById(userDetailsID);
        }

        public bool Update(UserDetails userDetails)
        {
            if (userDetails == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserDetailRepository.Update(userDetails);
            if (result == null)
            {
                return false;
            }
            return true;
        }
    }
}
