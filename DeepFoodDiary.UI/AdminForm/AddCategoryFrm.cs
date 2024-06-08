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
    public partial class AddCategoryFrm : KryptonForm
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public AddCategoryFrm()
        {
            var config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<ModelProfiler>();
                });
            _mapper = config.CreateMapper();
            _categoryService = new CategoryService();
            InitializeComponent();
            GetCategory();
        }
        int updatesCategoryId;

        private int CategoryIdSelect()
        {
            return (int)dgw_Category.SelectedRows[0].Cells["Id"].Value;
        }
        private void GetCategory()
        {
            dgw_Category.DataSource = null;
            dgw_Category.DataSource = _mapper.Map<List<CategoryVM>>(_categoryService.GetAll());
            dgw_Category.Columns["Id"].Visible = false;
            MealAreaClear();
        }
        private void MealAreaClear()
        {
            txt_CategoryName.Text = string.Empty;
        }



        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatesCategoryId = CategoryIdSelect();
            var newupdatesCategory = _categoryService.GetById(updatesCategoryId);
            txt_CategoryName.Text = newupdatesCategory.CategoryName;
            btnCategoryAdd.Enabled = false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Önce MealIdSelect() metodu ile seçilen MealId'nin alınması ve kontrol edilmesi
            int mealId = CategoryIdSelect();
            if (mealId == 0)
            {
                MessageBox.Show("Please select a Category to delete.");
                return;
            }

            // Silme işlemi yapılıyor
            if (_categoryService.Delete(mealId))
            {
                MessageBox.Show("Category deleted successfully.");
                GetCategory(); // Yeniden listeyi güncelleyelim
            }
            else
            {
                MessageBox.Show("Category deletion failed.");
            }
        }



        private void btnCategoryAdd_Click_1(object sender, EventArgs e)
        {
            // Kategori adı alanının boş olup olmadığını kontrol etme
            if (string.IsNullOrWhiteSpace(txt_CategoryName.Text))
            {
                MessageBox.Show("Category name cannot be empty. Please enter a valid category name.");
                return;
            }
            var existingCategory = _categoryService.GetByName(txt_CategoryName.Text);
            if (existingCategory != null)
            {
                MessageBox.Show("A meal with the same name already exists. Please enter a unique Meal name.");
                return;
            }
            // Yeni bir Category nesnesi oluşturma
            Category newCategory = new Category()
            {
                CategoryName = txt_CategoryName.Text,
            };
           
            // CategoryService aracılığıyla kategori ekleme işlemi
            if (_categoryService.Add(newCategory))
            {
                MessageBox.Show("Category added successfully.");
                GetCategory(); // Kategorileri yeniden yükleme
            }
            else
            {
                MessageBox.Show("Error adding category.");
                GetCategory(); // Kategorileri yeniden yükleme
            }
        }

        private void btn_CategoryUpdate_Click_1(object sender, EventArgs e)
        {
            // Önce updatesMealsId kontrolü yapılmalı
            if (updatesCategoryId == 0)
            {
                MessageBox.Show("Please select a Category to update.");
                return;
            }

            // Daha sonra MealName'in boş olup olmadığı kontrol edilmeli
            if (string.IsNullOrWhiteSpace(txt_CategoryName.Text))
            {
                MessageBox.Show("Category name cannot be empty.");
                return;
            }

            // Güncellenecek Meal'in alınması
            var newUpdatesCategory = _categoryService.GetById(updatesCategoryId);
            if (newUpdatesCategory == null)
            {
                MessageBox.Show("Selected Category not found.");
                return;
            }

            // MealName'in güncellenmesi ve servise gönderilmesi
            newUpdatesCategory.CategoryName = txt_CategoryName.Text;
            if (_categoryService.Update(newUpdatesCategory))
            {
                MessageBox.Show("Category updated successfully.");
                GetCategory(); // Yeniden listeyi güncelleyelim
            }
            else
            {
                MessageBox.Show("Category update failed.");
            }
            btnCategoryAdd.Enabled = true;
        }

        private void bipsButton1_Click(object sender, EventArgs e)
        {
            AddMealFrm addMEalFrm = new AddMealFrm();
            addMEalFrm.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminRaporFrm adminFrm = new AdminRaporFrm();
            adminFrm.Show();
            this.Hide();
        }
    }
}
