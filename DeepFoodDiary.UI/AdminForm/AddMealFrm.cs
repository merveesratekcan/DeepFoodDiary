using AutoMapper;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.MODEL.VMs;
using DeepFoodDiary.UI.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFoodDiary.UI
{
    public partial class AddMealFrm : KryptonForm
    {
        private readonly IMealService _mealService;
        private readonly IMapper _mapper;
        public AddMealFrm()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<ModelProfiler>();
                });
            _mapper = config.CreateMapper();
            _mealService = new MealService();
            InitializeComponent();
            GetMeals();

        }
        int updatesMealsId;

        private int MealIdSelect()
        {
            return (int)dgw_Meal.SelectedRows[0].Cells["Id"].Value;
        }
        private void GetMeals()
        {
            dgw_Meal.DataSource = null;
            dgw_Meal.DataSource = _mapper.Map<List<MealVM>>(_mealService.GetAll());
            dgw_Meal.Columns["Id"].Visible = false;
            MealAreaClear();
        }
        private void MealAreaClear()
        {
            txt_MealName.Text = string.Empty;
        }


        private void btnUpdateMeal_Click(object sender, EventArgs e)
        {
            // Önce updatesMealsId kontrolü yapılmalı
            if (updatesMealsId == 0)
            {
                MessageBox.Show("Please select a meal to update.");
                return;
            }

            // Daha sonra MealName'in boş olup olmadığı kontrol edilmeli
            if (string.IsNullOrWhiteSpace(txt_MealName.Text))
            {
                MessageBox.Show("Meal name cannot be empty.");
                return;
            }

            // Güncellenecek Meal'in alınması
            var newUpdatesMeal = _mealService.GetById(updatesMealsId);
            if (newUpdatesMeal == null)
            {
                MessageBox.Show("Selected meal not found.");
                return;
            }

            // MealName'in güncellenmesi ve servise gönderilmesi
            newUpdatesMeal.MealName = txt_MealName.Text;
            if (_mealService.Update(newUpdatesMeal))
            {
                MessageBox.Show("Meal updated successfully.");
                GetMeals(); // Yeniden listeyi güncelleyelim
            }
            else
            {
                MessageBox.Show("Meal update failed.");
            }
            btnAddMeal.Enabled = true;
        }


        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatesMealsId = MealIdSelect();
            var newupdatesMeal = _mealService.GetById(updatesMealsId);
            txt_MealName.Text = newupdatesMeal.MealName;
            btnAddMeal.Enabled = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Önce MealIdSelect() metodu ile seçilen MealId'nin alınması ve kontrol edilmesi
            int mealId = MealIdSelect();
            if (mealId == 0)
            {
                MessageBox.Show("Please select a meal to delete.");
                return;
            }

            // Silme işlemi yapılıyor
            if (_mealService.Delete(mealId))
            {
                MessageBox.Show("Meal deleted successfully.");
                GetMeals(); // Yeniden listeyi güncelleyelim
            }
            else
            {
                MessageBox.Show("Meal deletion failed.");
            }
        }

        private void btnAddMeal_Click_1(object sender, EventArgs e)
        {
            // Kategori adı alanının boş olup olmadığını kontrol etme
            if (string.IsNullOrWhiteSpace(txt_MealName.Text))
            {
                MessageBox.Show("Meal name cannot be empty. Please enter a valid Meal name.");
                return;
            }
            var existingMeal = _mealService.GetByName(txt_MealName.Text);
            if (existingMeal != null)
            {
                MessageBox.Show("A meal with the same name already exists. Please enter a unique Meal name.");
                return;
            }
            Meal newMeal = new Meal()
            {
                MealName = txt_MealName.Text,
            };
            if (_mealService.Add(newMeal))
            {
                MessageBox.Show("Meal Added Success");
                GetMeals();
                return;
            }
            MessageBox.Show("Meal Added Eror");
            GetMeals();

            return;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AddCategoryFrm addCategoryFrm = new AddCategoryFrm();
            addCategoryFrm.Show();
            this.Hide();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            btnGoHome addFoodFrm = new btnGoHome();
            addFoodFrm.Show();
            this.Hide();
        }

       
    }
}

