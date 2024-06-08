using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.MODEL.VMs;

public class UserMealFoodVM
{
    public int Id { get; set; } 
    public int TakenCalorie { get; set; }
    public DateTime? MealEateDate { get; set; }
    public int Portion { get; set; }
    public int UserID { get; set; }
    public string MealName { get; set; }
    public string FoodName { get; set; }
    public string Protein { get; set;}
    public string Fat { get; set;}
    public string Carbonhydrate { get;set;}
    public int FoodID { get; set; }
    public int MealID { get; set; }
    public string FullName {  get; set; }   
    public string CategoryName {  get; set; }



}
