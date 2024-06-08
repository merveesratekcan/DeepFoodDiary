using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService
{
    public interface IFoodService
    {
        bool Add(Food food);
        bool Update(Food food);
        bool Delete(int foodID);
        List<Food> GetAll();
        Food GetById(int foodID);

        Food GetByName(string foodName);
    }
}
