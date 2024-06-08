using DeepFoodDiary.ENTITY.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepFoodDiary.MODEL.VMs;

namespace DeepFoodDiary.UI.Mapper;

public class ModelProfiler : Profile
{
    public ModelProfiler()
    {
        CreateMap<Category, CategoryVM>();
        CreateMap<Food, FoodVM>();
        CreateMap<Meal, MealVM>();
        CreateMap<UserDetails, UserDetailVM>();
        CreateMap<UserMealFood, UserMealFoodVM>().ReverseMap();
            


    }
}
