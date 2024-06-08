using DeepFoodDiary.DAL.Repositories;
using DeepFoodDiary.DAL.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.DAL
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        public static UnitOfWork Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UnitOfWork();
                }

                return instance;
            }


        }
        public IAdminRepository AdminRepository 
        { 
            get
            {
              
                return new AdminRepository();
            } 
        }
        public ICategoryRepository CategoryRepository
        { 
            get
            {
                return new CategoryRepository();
            } 
        }
        public IFoodRepository FoodRepository
        { 
            get
            {
                return new FoodRepository();
            }
        }
      
        public IMealRepository MealRepository
        { 
            get
            {
                return new MealRepository();
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                return new UserRepository();
            }
        }
        public IUserDetailRepository UserDetailRepository
        {
            get
            {
                return new UserDetailRepository();
            }
        }
        public IUserMealFoodRepository UserMealFoodRepository
        {
            get
            {
                return new UserMealFoodRepository();
            }
        }
    }
}
