using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService
{
    public interface ICategoryService
    {
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(int categoryID);
        List<Category> GetAll();
        Category GetById(int categoryID);
        Category GetByName(string categoryName);

    }
}
