using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.DAL;
using DeepFoodDiary.DAL.AddDbContext;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.MODEL.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Services
{
    public class MealService : IMealService
    {
        public bool Add(Meal meal)
        {
            if (meal != null)
            {
                var result = UnitOfWork.Instance.MealRepository.Add(meal);
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool Delete(int mealID)
        {
            if (mealID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.MealRepository.Delete(mealID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<Meal> GetAll()
        {
            return UnitOfWork.Instance.MealRepository.GetAll();
        }

        public Meal GetById(int mealID)
        {
            if (mealID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.MealRepository.GetById(mealID);
        }

        public Meal GetByName(string mealName)
        {
            // İlgili meal adına sahip olan kaydı veritabanından getir
            return UnitOfWork.Instance.MealRepository.Find(m => m.MealName == mealName);
        }

       


        public bool Update(Meal meal)
        {
            if (meal == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.MealRepository.Update(meal);
            if (result == null)
            {
                return false;

            }
            return true;
        }
    }
}
