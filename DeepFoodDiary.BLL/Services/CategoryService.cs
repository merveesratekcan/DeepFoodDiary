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
    public class CategoryService : ICategoryService
    {
        public bool Add(Category category)
        {
            if (category != null)
            {
                var result = UnitOfWork.Instance.CategoryRepository.Add(category);
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool Delete(int categoryID)
        {
            if (categoryID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.CategoryRepository.Delete(categoryID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<Category> GetAll()
        {
            return UnitOfWork.Instance.CategoryRepository.GetAll();
        }

        public Category GetById(int categoryID)
        {
            if (categoryID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.CategoryRepository.GetById(categoryID);
        }

        public Category GetByName(string categoryName)
        {
            return UnitOfWork.Instance.CategoryRepository.Find(m => m.CategoryName == categoryName);
        }

        public bool Update(Category category)
        {
            if (category == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.CategoryRepository.Update(category);
            if (result == null)
            {
                return false;

            }
            return true;
        }
    }
}
