using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Interfaces.IService
{
    public interface IUserMealFoodService
    {
        //for user
        bool Add(UserMealFood userMealFood);
        bool Update(UserMealFood userMealFood);
        bool Delete(int userMealFoodID);
        UserMealFood GetById(int userMealFoodID);
        List<UserMealFood> GetAll();
        // ilgili öğünün
        string GetMealCaloriesOfUser(Meal meal, User user, int compareDay);
        //total öğünün
        string GetTotalMealCaloriesOfUser(int userID, DateTime date);
        string GetWeeklyMonthlyComparison(DateTime startDate, DateTime endDate);
        string GetWeeklyMonthlyComparison(int userID, DateTime startDate, DateTime endDate);
        string GetDailyComparison(int userID, DateTime date);
        string GetMealConsumptionReport(DateTime startDate, DateTime endDate);
        string GetMealPortion(DateTime startDate, DateTime endDate);





    }

}
