using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepFoodDiary.MODEL.VMs;

public class UserDetailVM
{
    public int Id { get; set; } 
    public string FullName { get; set; }
    public bool Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public float TotalCalorie { get; set; }
    public int UserId { get; set; }
}
