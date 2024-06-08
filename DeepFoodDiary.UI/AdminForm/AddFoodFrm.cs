using AutoMapper;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.DAL.AddDbContext;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.MODEL.VMs;
using DeepFoodDiary.UI.MainForm;
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

namespace DeepFoodDiary.UI;

public partial class btnGoHome : KryptonForm
{
    private readonly ICategoryService _categoryService;
    private readonly IFoodService _foodService;
    private readonly IMapper _mapper;
    private readonly DiaryDbContext _diaryDbContext;
    public btnGoHome()
    {
        InitializeComponent();
        var config = new MapperConfiguration(
         cfg =>
         {
             cfg.AddProfile<ModelProfiler>();
         });
        _mapper = config.CreateMapper();
        _categoryService = new CategoryService();
        _foodService = new FoodService();
        _diaryDbContext = new DiaryDbContext();
        GetFood();

    }
    int updatesFoodId;
    private int FoodIdSelect()
    {
        return (int)dgw_Food.SelectedRows[0].Cells["Id"].Value;
    }



    private void GetFood()

    {

        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

        dgw_Food.DataSource = null;

        dgw_Food.DataSource = _mapper.Map<List<FoodVM>>(_foodService.GetAll());


        cmbFoodCategory.DataSource = _categoryService.GetAll();

        cmbFoodCategory.DisplayMember = "CategoryName";

        cmbFoodCategory.ValueMember = "Id";

        var foods = _foodService.GetAll().Select(x => new

        {

            x.Id,

            x.Picture,

            x.FoodName,

            x.Calorie,

            x.Protein,

            x.Carbonhydrate,

            x.Fat,

           

        }); dgw_Food.DataSource = foods.ToList();

        //var foods = _diaryDbContext.Foods.Where(x => x.Status != ENTITY.Enums.Statu.Deleted).Select(x => new

        //{

        //    x.Id,

        //    x.FoodName,

        //    x.Calorie,

        //    x.Protein,

        //    x.Carbonhydrate,

        //    x.Fat,

        //    x.Picture

        //}); dgw_Food.DataSource = foods.ToList();

        dgw_Food.Columns["Id"].Visible = false;

        FoodAreaClear();

    }

    private void FoodAreaClear()

    {

        pbFood.Visible = false;

        txt_FoodName.Text = string.Empty;

        txtKarbonhidrat.Text = string.Empty;

        txtProtein.Text = string.Empty;

        txtYağ.Text = string.Empty;

        nudFoodCalorie.Value = 0;

        pbFood.Refresh();


    }



    private void btn_FoodUpdate_Click(object sender, EventArgs e)
    {
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // Önce MealIdSelect() metodu ile seçilen MealId'nin alınması ve kontrol edilmesi
        int foodId = FoodIdSelect();
        if (foodId == 0)
        {
            MessageBox.Show("Please select a Food to delete.");
            return;
        }


        // Silme işlemi yapılıyor
        if (_foodService.Delete(foodId))
        {
            MessageBox.Show("Food deleted successfully.");
            GetFood(); // Yeniden listeyi güncelleyelim
        }
        else
        {
            MessageBox.Show("Food deletion failed.");
        }

    }
    private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        updatesFoodId = FoodIdSelect();
        var newupdatesFood = _foodService.GetById(updatesFoodId);
        txt_FoodName.Text = newupdatesFood.FoodName;
        txtKarbonhidrat.Text = newupdatesFood.Carbonhydrate;
        txtProtein.Text = newupdatesFood.Protein;
        txtYağ.Text = newupdatesFood.Fat;
        nudFoodCalorie.Value = (decimal)newupdatesFood.Calorie;
        cmbFoodCategory.SelectedValue = newupdatesFood.CategoryId;
        if (newupdatesFood.Picture != null && newupdatesFood.Picture.Length > 0)
        {
            using (MemoryStream ms = new MemoryStream(newupdatesFood.Picture))
            {
                pbFood.Image = Image.FromStream(ms);
            }
        }
        else
        {
            pbFood.Image = null; // Eğer resim verisi yoksa, PictureBox'u temizle
        }
        btnFoodAdd.Enabled = false;
    }

    private void btnFoodAdd_Click_1(object sender, EventArgs e)
    {
        if (pbFood != null && pbFood.Image != null)

        {

            // PictureBox ve resim dolu ise buraya gir

            MemoryStream stream = new MemoryStream();

            pbFood.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            if (stream.Length == 0)

            {

                MessageBox.Show("Please upload a picture.");

                return;

            }

            // Kategori adı alanının boş olup olmadığını kontrol etme

            if (string.IsNullOrWhiteSpace(txt_FoodName.Text) ||

                string.IsNullOrWhiteSpace(txtProtein.Text) ||

                string.IsNullOrWhiteSpace(txtKarbonhidrat.Text) ||

                string.IsNullOrWhiteSpace(txtYağ.Text) ||

                nudFoodCalorie.Value == 0)

            {

                MessageBox.Show("All fields must be filled. Please enter valid values.");

                return;

            }

            // Yeni bir Food nesnesi oluşturma
            var existingMeal = _foodService.GetByName(txt_FoodName.Text);
            if (existingMeal != null)
            {
                MessageBox.Show("A meal with the same name already exists. Please enter a unique Meal name.");

            }
            Food newFood = new Food()

            {
                Picture = stream.ToArray(),

                FoodName = txt_FoodName.Text,

                Protein = txtProtein.Text,

                Carbonhydrate = txtKarbonhidrat.Text,

                Fat = txtYağ.Text,

                Calorie = (double)nudFoodCalorie.Value,

                CategoryId = _diaryDbContext.Categories.Where(x => x.CategoryName == cmbFoodCategory.Text).Select(x => x.Id).FirstOrDefault(),

                

            };

            // FoodService aracılığıyla Food ekleme işlemi
            
            if (_foodService.Add(newFood))

            {

                MessageBox.Show("Food added successfully.");

                GetFood(); // Food yeniden yükleme

            }

            else

            {

                MessageBox.Show("Error adding Food.");

                GetFood(); // Food yeniden yükleme

            }

        }

        else

        {

            MessageBox.Show("PictureBox or image is not initialized.");

        }
    }
 
    private void AddFoodFrm_Load(object sender, EventArgs e)
    {
        // PictureBox nesnesini oluşturun
        PictureBox pbFood = new PictureBox();
        pbFood.Size = new Size(114, 133); // PictureBox boyutunu ayarlayın
        pbFood.Location = new Point(205, 124); // PictureBox konumunu ayarlayın

        pbFood.SizeMode = PictureBoxSizeMode.StretchImage; // Ölçekleme modu

        // PictureBox'ı forma ekleyin
        this.Controls.Add(pbFood);
    }

    private void btnÜrünFotoEkle_Click_1(object sender, EventArgs e)
    {
        try
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "jpg";
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            pbFood.Image = Image.FromFile(path);
            pbFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        catch
        {
            throw new Exception("Lütfen bir resim seçiniz");
        }
    }

    private void btn_FoodUpdate_Click_1(object sender, EventArgs e)
    {

        // PictureBox ve resim dolu ise buraya gir
        if (pbFood != null && pbFood.Image != null)
        {
            MemoryStream stream = new MemoryStream();
            pbFood.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            // stream pozisyonunu sıfırla
            stream.Position = 0;
        }
        else
        {
            MessageBox.Show("PictureBox or image is null.");
            return;
        }

        // Önce updatesMealsId kontrolü yapılmalı
        if (updatesFoodId == 0)
        {
            MessageBox.Show("Please select a Food to update.");
            return;
        }

        // Daha sonra MealName'in boş olup olmadığı kontrol edilmeli
        if (string.IsNullOrWhiteSpace(txt_FoodName.Text))
        {
            MessageBox.Show("Food name cannot be empty.");
            return;
        }

        // Güncellenecek Food'in alınması
        var newUpdatesFood = _foodService.GetById(updatesFoodId);
        if (newUpdatesFood == null)
        {
            MessageBox.Show("Selected Food not found.");
            return;
        }

        // MealName'in güncellenmesi ve servise gönderilmesi
        newUpdatesFood.FoodName = txt_FoodName.Text;
        newUpdatesFood.Carbonhydrate = txtKarbonhidrat.Text;
        newUpdatesFood.Protein = txtProtein.Text;
        newUpdatesFood.Calorie = (double)nudFoodCalorie.Value;
        if (cmbFoodCategory.SelectedValue != null)
        {
            newUpdatesFood.CategoryId = (int)cmbFoodCategory.SelectedValue;
        }

        // PictureBox ve resim kontrolü yapıldıktan sonra resim güncellenmesi
        if (pbFood != null && pbFood.Image != null)
        {
            // Eğer PictureBox'taki resim güncellendi ise yeni resmi kaydet
            MemoryStream stream = new MemoryStream();
            pbFood.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            newUpdatesFood.Picture = stream.ToArray();
        }

        // FoodService aracılığıyla Food güncelleme işlemi
        if (_foodService.Update(newUpdatesFood))
        {
            MessageBox.Show("Food updated successfully.");
            GetFood(); // Yeniden listeyi güncelleyelim
        }
        else
        {
            MessageBox.Show("Food update failed.");
        }
        btnFoodAdd.Enabled = true;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        AddMealFrm addMealFrm = new AddMealFrm();
        addMealFrm.Show();
        this.Hide();
    }

    private void btnForward_Click(object sender, EventArgs e)
    {
        AdminRaporFrm admin = new AdminRaporFrm();
        admin.Show();
        this.Hide();
    }

    private void bipsButton1_Click(object sender, EventArgs e)
    {
        HomeFrm homeFrm = new HomeFrm();
        homeFrm.Show();
        this.Hide();
    }
}


