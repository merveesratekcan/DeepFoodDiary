using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.DAL;
using DeepFoodDiary.DAL.AddDbContext;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.MODEL.VMs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.BLL.Services
{
    public class UserMealFoodService : IUserMealFoodService
    {

        public bool Add(UserMealFood userMealFood)
        {
            if (userMealFood != null)
            {
                var result = UnitOfWork.Instance.UserMealFoodRepository.Add(userMealFood);
                if (result != null)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool Delete(int userMealFoodID)
        {
            if (userMealFoodID == 0)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserMealFoodRepository.Delete(userMealFoodID);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public List<UserMealFood> GetAll()
        {
            return UnitOfWork.Instance.UserMealFoodRepository.GetAll();
        }

        public UserMealFood GetById(int userMealFoodID)
        {
            if (userMealFoodID == 0)
            {
                return null;
            }
            return UnitOfWork.Instance.UserMealFoodRepository.GetById(userMealFoodID);
        }

        public string GetMealCaloriesOfUser(Meal meal, User user, int compareDay)
        {
            throw new NotImplementedException();
        }

        public string GetTotalMealCaloriesOfUser(int userID, DateTime date)
        {
            throw new NotImplementedException();


        }

        public string GetWeeklyMonthlyComparison(DateTime startDate, DateTime endDate)
        {
            var userMealFoodsWithUsers = UnitOfWork.Instance.UserMealFoodRepository.GetAll()
                .Where(umf => umf.MealEateDate >= startDate && umf.MealEateDate <= endDate)
                .Select(umf => new UserMealFoodVM
                {
                    Id = umf.Id,
                    TakenCalorie = umf.TakenCalorie,
                    MealEateDate = umf.MealEateDate,
                    Portion = umf.Portion,
                    UserID = umf.UserID,
                    MealName = umf.Meal.MealName,
                    FoodName = umf.Food.FoodName,
                    Protein = umf.Food.Protein,
                    Fat = umf.Food.Fat,
                    Carbonhydrate = umf.Food.Carbonhydrate,
                    FoodID = umf.FoodID,
                    MealID = umf.MealId,
                    FullName = umf.Users.UserName
                }).ToList();

            var weeklyMontlyMeals = userMealFoodsWithUsers
                .GroupBy(umf => new
                {
                    umf.UserID,
                    umf.MealName,
                    umf.FullName,
                    umf.MealEateDate.Value.Year,
                    WeekOfYear = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        umf.MealEateDate.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                }).Select(g => new
                {

                    UserID = g.Key.UserID,
                    UserName = g.Key.FullName,
                    MealName = g.Key.MealName,
                    Year = g.Key.Year,
                    WeekOfYear = g.Key.WeekOfYear,
                    TotalCalories = g.Sum(umf => umf.TakenCalorie * umf.Portion)
                }).ToList();

            var monthlyMeals = userMealFoodsWithUsers
                .GroupBy(umf => new
                {

                    umf.UserID,
                    umf.FullName,
                    umf.MealName,
                    umf.MealEateDate.Value.Year,
                    umf.MealEateDate.Value.Month
                }).Select(g => new
                {

                    UserID = g.Key.UserID,
                    UserName = g.Key.FullName,
                    MealName = g.Key.MealName,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalCalories = g.Sum(umf => umf.TakenCalorie * umf.Portion)
                }).ToList();

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("Weekly-Monthly Comparison:");

            resultBuilder.AppendLine("Weekly Report:");
            foreach (var item in weeklyMontlyMeals)
            {
                resultBuilder.AppendLine($"{item.UserID},{item.UserName}, {item.MealName}, {item.Year}, " +
                    $"{item.WeekOfYear},  {item.TotalCalories} ");
            }

            resultBuilder.AppendLine("\nMonthly Report:");
            foreach (var item in monthlyMeals)
            {
                resultBuilder.AppendLine($"{item.UserID},{item.UserName}, {item.MealName},  {item.Year}, " +
                    $"{item.Month},  {item.TotalCalories} ");
            }

            return resultBuilder.ToString();
        }



        public bool Update(UserMealFood userMealFood)
        {
            if (userMealFood == null)
            {
                return false;
            }
            var result = UnitOfWork.Instance.UserMealFoodRepository.Update(userMealFood);
            if (result == null)
            {
                return false;
            }
            return true;
        }


        public string GetWeeklyMonthlyComparison(int userID, DateTime startDate, DateTime endDate)
        {
            var userMealFoodsWithUsers = UnitOfWork.Instance.UserMealFoodRepository.GetAll()
                .Where(umf => umf.UserID == userID && umf.MealEateDate >= startDate && umf.MealEateDate <= endDate)
                .Select(umf => new UserMealFoodVM
                {
                    Id = umf.Id,
                    TakenCalorie = umf.TakenCalorie,
                    MealEateDate = umf.MealEateDate,
                    Portion = umf.Portion,
                    UserID = umf.UserID,
                    MealName = umf.Meal.MealName,
                    FoodName = umf.Food.FoodName,
                    Protein = umf.Food.Protein,
                    Fat = umf.Food.Fat,
                    Carbonhydrate = umf.Food.Carbonhydrate,
                    FoodID = umf.FoodID,
                    MealID = umf.MealId,
                    FullName = umf.Users.UserName
                }).ToList();

            var weeklyMontlyMeals = userMealFoodsWithUsers
                .GroupBy(umf => new
                {
                    umf.UserID,
                    umf.MealName,
                    umf.FullName,
                    umf.MealEateDate.Value.Year,
                    WeekOfYear = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                        umf.MealEateDate.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                }).Select(g => new
                {

                    UserID = g.Key.UserID,
                    UserName = g.Key.FullName,
                    MealName = g.Key.MealName,
                    Year = g.Key.Year,
                    WeekOfYear = g.Key.WeekOfYear,
                    TotalCalories = g.Sum(umf => umf.TakenCalorie * umf.Portion)
                }).ToList();

            var monthlyMeals = userMealFoodsWithUsers
                .GroupBy(umf => new
                {

                    umf.UserID,
                    umf.FullName,
                    umf.MealName,
                    umf.MealEateDate.Value.Year,
                    umf.MealEateDate.Value.Month
                }).Select(g => new
                {

                    UserID = g.Key.UserID,
                    UserName = g.Key.FullName,
                    MealName = g.Key.MealName,
                    Year = g.Key.Year,
                    Month = g.Key.Month,
                    TotalCalories = g.Sum(umf => umf.TakenCalorie * umf.Portion)
                }).ToList();

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("Weekly-Monthly Comparison:");

            resultBuilder.AppendLine("Weekly Report:");
            foreach (var item in weeklyMontlyMeals)
            {
                resultBuilder.AppendLine($"{item.UserID},{item.UserName}, {item.MealName}, {item.Year}, " +
                    $"{item.WeekOfYear},  {item.TotalCalories} ");
            }

            resultBuilder.AppendLine("\nMonthly Report:");
            foreach (var item in monthlyMeals)
            {
                resultBuilder.AppendLine($"{item.UserID},{item.UserName}, {item.MealName},  {item.Year}, " +
                    $"{item.Month},  {item.TotalCalories} ");
            }

            return resultBuilder.ToString();
        }

        public string GetDailyComparison(int userID, DateTime date)
        {
            var userMealFoodsWithUsers = UnitOfWork.Instance.UserMealFoodRepository.GetAll()
        .Where(umf => umf.UserID == userID && umf.MealEateDate.Date == date.Date)
        .Select(umf => new UserMealFoodVM
        {
            Id = umf.Id,
            TakenCalorie = umf.TakenCalorie,
            MealEateDate = umf.MealEateDate,
            Portion = umf.Portion,
            UserID = umf.UserID,
            MealName = umf.Meal.MealName,
            FoodName = umf.Food.FoodName,
            Protein = umf.Food.Protein,
            Fat = umf.Food.Fat,
            Carbonhydrate = umf.Food.Carbonhydrate,
            FoodID = umf.FoodID,
            MealID = umf.MealId,
            FullName = umf.Users.UserName
        }).ToList();

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("Daily Comparison:");
            resultBuilder.AppendLine($"Date: {date.ToShortDateString()}\n");

            foreach (var item in userMealFoodsWithUsers)
            {
                resultBuilder.AppendLine($"UserID: {item.UserID}, UserName: {item.FullName}, " +
                    $"MealName: {item.MealName}, FoodName: {item.FoodName}, " +
                    $"Calorie: {item.TakenCalorie}, Portion: {item.Portion}");
            }

            return resultBuilder.ToString();
        }

        public string GetMealConsumptionReport(DateTime startDate, DateTime endDate)
        {
            var userMealFoodsWithUsers = UnitOfWork.Instance.UserMealFoodRepository.GetAll()
        .Where(umf => umf.MealEateDate >= startDate && umf.MealEateDate <= endDate)
        .Select(umf => new UserMealFoodVM
        {
            Id = umf.Id,
            TakenCalorie = umf.TakenCalorie,
            MealEateDate = umf.MealEateDate,
            Portion = umf.Portion,
            UserID = umf.UserID,
            MealName = umf.Meal.MealName,
            FoodName = umf.Food.FoodName,
            Protein = umf.Food.Protein,
            Fat = umf.Food.Fat,
            Carbonhydrate = umf.Food.Carbonhydrate,
            FoodID = umf.FoodID,
            MealID = umf.MealId,
            CategoryName = umf.Food.Category.CategoryName
        }).ToList();

            // Öğün bazında yenen yemekleri ve miktarlarını topla
            var mealConsumption = userMealFoodsWithUsers
                .GroupBy(umf => new
                {
                    umf.MealName,
                    umf.FoodName
                }).Select(g => new
                {
                    MealName = g.Key.MealName,
                    FoodName = g.Key.FoodName,
                    TotalPortion = g.Sum(umf => umf.Portion)
                }).ToList();

            // En çok yenilen yemekleri bul
            var mostConsumedFoods = mealConsumption
                .GroupBy(mc => mc.FoodName)
                .Select(g => new
                {
                    FoodName = g.Key,
                    TotalPortion = g.Sum(mc => mc.TotalPortion)
                }).OrderByDescending(x => x.TotalPortion)
                .Take(5) // İlk 5 en çok yenilen yemeği al
                .ToList();

            // Raporu oluştur
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("Meal Consumption Report:");
            resultBuilder.AppendLine();

            resultBuilder.AppendLine("Most Consumed Foods:");
            foreach (var item in mostConsumedFoods)
            {
                resultBuilder.AppendLine($"{item.FoodName}: {item.TotalPortion} portions");
            }

            return resultBuilder.ToString();
        }

        public string GetMealPortion(DateTime startDate, DateTime endDate)
        {
            var userMealFoods = UnitOfWork.Instance.UserMealFoodRepository.GetAll()
           .Where(umf => umf.MealEateDate >= startDate && umf.MealEateDate <= endDate)
           .GroupBy(umf => new { umf.Meal.MealName, umf.Food.FoodName })
           .Select(g => new
           {
               FoodName = g.Key.FoodName,
               MealName = g.Key.MealName,
               TotalPortion = g.Sum(umf => umf.Portion)
           })
           .ToList();

            var mealConsumptionReport = new StringBuilder();
            mealConsumptionReport.AppendLine("How many portions of food were eaten at which meal?");
            mealConsumptionReport.AppendLine("Food Name Meal Name Total Portion");

            foreach (var item in userMealFoods)
            {
                mealConsumptionReport.AppendLine($"{item.FoodName},    {item.MealName},         {item.TotalPortion}");
            }

            return mealConsumptionReport.ToString();
        }
    }
}
