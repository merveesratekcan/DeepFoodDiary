using AutoMapper;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.MODEL.VMs;
using DeepFoodDiary.UI.Mapper;
using DeepFoodDiary.UI.UserForm;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFoodDiary.UI.CategoryForm;

public partial class UserAddMealFrm : KryptonForm
{
    private readonly IUserMealFoodService _userMealFoodService;
    private readonly IFoodService _foodService;
    private readonly IMealService _mealService;

    private readonly IMapper _mapper;
    public int Id { get; set; }
    public UserAddMealFrm(int id)
    {
        var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<ModelProfiler>();

                });
        _mapper = config.CreateMapper();
        _userMealFoodService = new UserMealFoodService();
        _foodService = new FoodService();
        _mealService = new MealService();

        InitializeComponent();
     
        Id = id;
        GetMeal();
        GetBreakfastData();
        GetSnackData();
        GetDinnerhData();
        GetLunchData();
    }

    private void GetMeal()
    {
        dgw_AddedMeal.DataSource = null;
        var userMealFoods = _userMealFoodService.GetAll().Where(x=>x.UserID==Id).Select(x => new
        {
            
            x.Id,   
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
            

        });

        dgw_AddedMeal.DataSource = userMealFoods.ToList();
        dgw_AddedMeal.Columns["Id"].Visible = false;

        cmbMeal.DataSource = _mealService.GetAll();

        cmbMeal.DisplayMember = "MealName";

        cmbMeal.ValueMember = "Id";

    }
    private void btnProfil_Click(object sender, EventArgs e)
    {
        UserProfileFrm userProfilFrm = new UserProfileFrm(Id);
        userProfilFrm.Show();
        this.Hide();
    }

   

    private void btnVegetable_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10000).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();

    }

    private void btnFruits_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10001).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnDairyProducts_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10002).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnMeatProducts_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10003).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnFishandSeafood_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10004).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnLegumes_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10005).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnGrains_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10006).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnSugarsAndSweets_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10007).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnBeverages_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10008).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnSoups_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10009).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnBakeryProducts_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10010).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnSpicesAndSauces_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10011).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnSnack_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10012).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnSalad_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10014).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnMainFood_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10015).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnForBreakfast_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10016).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void btnAlcoholicBeverages_Click(object sender, EventArgs e)
    {
        var foods = _foodService.GetAll().Where(x => x.CategoryId == 10013).Select(x => new
        {
            x.Picture,
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        }); dgwCategory.DataSource = foods.ToList();
    }

    private void txtSearchFood_TextChanged(object sender, EventArgs e)
    {
        string searchText = txtSearchFood.Text;

        // Yazılan kelimeye göre arama işlemlerini gerçekleştir
        FindFoodByName(searchText);
    }

    private void FindFoodByName(string name)
    {
        // İlgili kategoriye göre yiyecekleri getir
        var foods = _foodService.GetAll().Where(x => x.FoodName.ToLower().Contains(name)).Select(x => new
        {
            x.FoodName,
            x.Calorie,
            x.Protein,
            x.Carbonhydrate,
            x.Fat
        });

        // DataGridView'e yiyecekleri bind et
        dgwCategory.DataSource = foods.ToList();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        
        if (dgw_AddedMeal.SelectedRows.Count > 0)
        {
            string foodNames = dgw_AddedMeal.SelectedRows[0].Cells["FoodName"].Value.ToString();
            int id = _userMealFoodService.GetAll().FirstOrDefault(x => x.Food.FoodName == foodNames).Id;

            _userMealFoodService.Delete(id);
            MessageBox.Show("Başarıyla silindi");

            // Silme işleminden sonra veri kaynağını güncelle
            GetBreakfastData();
            GetLunchData();
            GetMeal();
            GetDinnerhData();
            GetSnackData();
        }
        else
        {
            MessageBox.Show("Lütfen bir satır seçin.");
        }
    }


    private void btnSaveMealUser_Click(object sender, EventArgs e)
    {
        int id = this.Id;
        string foodName = dgwCategory.SelectedRows[0].Cells["FoodName"].Value.ToString();
        string mealName = cmbMeal.Text;
        int calorie = Convert.ToInt32(dgwCategory.SelectedRows[0].Cells["Calorie"].Value);
        string protein = dgwCategory.SelectedRows[0].Cells["Protein"].Value.ToString();
        string carbonhydrate = dgwCategory.SelectedRows[0].Cells["Carbonhydrate"].Value.ToString();
        string fat = dgwCategory.SelectedRows[0].Cells["Fat"].Value.ToString();
        int portion = (int)nudPortion.Value;
        int takenCalorie = (int)calorie * portion;
        var food = _foodService.GetAll().FirstOrDefault(x => x.FoodName == foodName);
        int foodId = food != null ? food.Id : 0;
        var meal = _mealService.GetAll().FirstOrDefault(x => x.MealName == mealName);
        int mealId = meal != null ? meal.Id : 0;

        UserMealFood userMealFood = new UserMealFood()
        {
            FoodID = foodId,
            Meal = meal,
            Food = food,
            MealEateDate = DateTime.Now.AddDays(-32),
            MealId = mealId,
            UserID = id,
            TakenCalorie = takenCalorie,
            Portion = portion
        };

        _userMealFoodService.Add(userMealFood);

        // Seçilen öğün türüne göre datagridview'e gönderme işlemi
        if (mealName.ToLower() == "breakfast")
        {
            AddToBreakfastDataGridView(userMealFood);
        }
        else if (mealName.ToLower() == "lunch")
        {
            AddToLunchDataGridView(userMealFood);
        }
        else if(mealName.ToLower() == "dinner")
        {
            AddToDinnerDataGridView(userMealFood);
        }else if(mealName.ToLower() == "snack")
        {
            AddToSnackDataGridView(userMealFood);
        }
        // Diğer öğün türlerine göre de aynı şekilde işlemleri yapabilirsiniz

        // Tüm kullanıcı öğün yiyeceklerini al ve dgw_AddedMeal'e aktar
        var userMealFoods = _userMealFoodService.GetAll().Where(x=>x.UserID==Id).Select(x => new
        {
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
        });

        dgw_AddedMeal.DataSource = userMealFoods.ToList();
    }
//--------------------------------------------------------------------
    private void AddToBreakfastDataGridView(UserMealFood userMealFood)
    {
        // Öğün türü breakfast ise DataGridView'in veri kaynağını güncelle
        var breakfastFoods = _userMealFoodService.GetAll()
            .Where(x => x.Meal.MealName.ToLower() == "breakfast"&&x.UserID==Id)
            .Select(x => new
            {
                x.Meal.MealName,
                x.Food.FoodName,
                x.Portion,
                x.TakenCalorie,
                x.MealEateDate
            }).ToList();

        dgwBreakfast.DataSource = null; // Önceki veriyi temizle
        dgwBreakfast.DataSource = breakfastFoods; // Yeni veriyi ata
    }

    private void AddToLunchDataGridView(UserMealFood userMealFood)
    {// Öğün türü lunch ise DataGridView'in veri kaynağını güncelle
        var lunchFoods = _userMealFoodService.GetAll()
            .Where(x => x.Meal.MealName.ToLower() == "lunch" && x.UserID == Id)
            .Select(x => new
            {
                x.Meal.MealName,
                x.Food.FoodName,
                x.Portion,
                x.TakenCalorie,
                x.MealEateDate
            }).ToList();

        dgwLunch.DataSource = null; // Önceki veriyi temizle
        dgwLunch.DataSource = lunchFoods; // Yeni veriyi ata
    }

    private void AddToDinnerDataGridView(UserMealFood userMealFood)
    {
        // Öğün türü dinner ise DataGridView'in veri kaynağını güncelle
        var dinnerFoods = _userMealFoodService.GetAll()
            .Where(x => x.Meal.MealName.ToLower() == "dinner" && x.UserID == Id)
            .Select(x => new
            {
                x.Meal.MealName,
                x.Food.FoodName,
                x.Portion,
                x.TakenCalorie,
                x.MealEateDate
            }).ToList();

        dgwDinner.DataSource = null; // Önceki veriyi temizle
        dgwDinner.DataSource = dinnerFoods; // Yeni veriyi ata
    }
    private void AddToSnackDataGridView(UserMealFood userMealFood)
    {
        // Öğün türü snack ise DataGridView'in veri kaynağını güncelle
        var snackFoods = _userMealFoodService.GetAll()
            .Where(x => x.Meal.MealName.ToLower() == "snack" && x.UserID == Id)
            .Select(x => new
            {
                x.Meal.MealName,
                x.Food.FoodName,
                x.Portion,
                x.TakenCalorie,
                x.MealEateDate
            }).ToList();

        dgwSnack.DataSource = null; // Önceki veriyi temizle
        dgwSnack.DataSource = snackFoods; // Yeni veriyi ata
    }

    //----------------------------------------------------------------------

    private void GetBreakfastData()
    {
        var breakfastFoods = _userMealFoodService.GetAll()
        .Where(x => x.Meal.MealName.ToLower() == "breakfast" && x.UserID == Id)
        .Select(x => new
        {
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
        }).ToList();

        dgwBreakfast.DataSource = breakfastFoods;
    }

    private void GetLunchData()
    {
        var lunchFoods = _userMealFoodService.GetAll()
        .Where(x => x.Meal.MealName.ToLower() == "lunch" && x.UserID == Id)
        .Select(x => new
        {
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
        }).ToList();

        dgwLunch.DataSource = lunchFoods;
    }

    private void GetDinnerhData()
    {
        var dinnerFoods = _userMealFoodService.GetAll()
        .Where(x => x.Meal.MealName.ToLower() == "dinner" && x.UserID == Id)
        .Select(x => new
        {
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
        }).ToList();

        dgwDinner.DataSource = dinnerFoods;
    }

    private void GetSnackData()
    {
        var snackFoods = _userMealFoodService.GetAll()
        .Where(x => x.Meal.MealName.ToLower() == "snack" && x.UserID == Id)
        .Select(x => new
        {
            x.Meal.MealName,
            x.Food.FoodName,
            x.Portion,
            x.TakenCalorie,
            x.MealEateDate
        }).ToList();

        dgwSnack.DataSource = snackFoods;
    }
}