using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService
{
    public interface IMealService
    {
        bool Add(Meal meal);
        bool Update(Meal meal);
        bool Delete(int mealID);
        Meal GetById(int mealID);
        List<Meal> GetAll();
        Meal GetByName(string mealName);



    }
}
