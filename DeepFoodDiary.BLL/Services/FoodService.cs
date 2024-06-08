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
    public class FoodService : IFoodService
    {
        public bool Add(Food food)
        {
            if (food != null)
            {
                var result = UnitOfWork.Instance.FoodRepository.Add(food);
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }


        public bool Delete(int foodID)
        {
            if (foodID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.FoodRepository.Delete(foodID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<Food> GetAll()
        {
            return UnitOfWork.Instance.FoodRepository.GetAll();
        }

        public Food GetById(int foodID)
        {
            if (foodID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.FoodRepository.GetById(foodID);
        }

        public Food GetByName(string foodName)
        {
            return UnitOfWork.Instance.FoodRepository.Find(m => m.FoodName == foodName);


        }

        public bool Update(Food food)
        {
            if (food == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.FoodRepository.Update(food);
            if (result == null)
            {
                return false;

            }
            return true;
        }
    }
}
