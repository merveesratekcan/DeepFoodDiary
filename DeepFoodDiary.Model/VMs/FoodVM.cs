using DeepFoodDiary.ENTITY.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.MODEL.VMs;

public class FoodVM
{
    public int Id { get; set; }
    public string FoodName { get; set; }
    public double Calorie { get; set; }
    public string Protein { get; set; }
    public string Carbonhydrate { get; set; }
    public string Fat { get; set; }
    public float Measurement { get; set; }

    public byte[]? Picture { get; set; }
    public PortionType PortionType { get; set; }
    public int CategoryId { get; set; }

}
