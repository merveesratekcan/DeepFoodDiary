using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.UI.CategoryForm;
using DeepFoodDiary.UI.MainForm;
using DeepFoodDiary.UI.UserForm;
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
    public partial class UserProfileFrm : KryptonForm
    {
        private readonly IUserDetailService _userDetailService;
        private readonly IUserService _userService;
        public int Id { get; set; }
        public UserProfileFrm(int id)
        {
            InitializeComponent();
            _userDetailService = new UserDetailService();
            _userService = new UserService();
            Id = id;
            LoadScreen();
        }
        private void btnUpdateHW_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblHeightUserPrfl.Text) || string.IsNullOrEmpty(lblWeightUserPrfl.Text))
            {
                MessageBox.Show("Height or Weight cannot be empty!");
                return;
            }

            // User nesnesini al
            var userUpdate = _userService.GetById(Id);
            if (userUpdate != null)
            {
                // User nesnesinden UserDetails bilgilerini alarak yeni bir UserDetails nesnesi oluştur
                var userDetails = userUpdate.UserDetails;
                userDetails.Weight = Convert.ToInt32(txtUpdateWeight.Text);
                userDetails.Height = Convert.ToInt32(txtUpdateHeight.Text);

                // UserDetails nesnesini kullanarak güncelleme yap
                _userDetailService.Update(userDetails);
                MessageBox.Show("Height and Weight successfully updated!");
                lblWeightUserPrfl.Text = "";
                lblHeightUserPrfl.Text = "";
                LoadScreen();
            }
            else
            {
                MessageBox.Show("User not found!");
            }


        }






        private void btnAddMealUser_Click(object sender, EventArgs e)
        {
            UserAddMealFrm userAddMealFrm = new UserAddMealFrm(Id);
            userAddMealFrm.Show();
            this.Hide();
        }



        private void btnMainProfil_Click(object sender, EventArgs e)
        {
            UserProfilMainFrm userMainFrm = new UserProfilMainFrm(Id);
            userMainFrm.Show();
            this.Hide();
        }


        private void LoadScreen()
        {
            int userId = Id; // veya yüklemek istediğiniz kullanıcının ID'si

            User user = _userService.GetById(userId);
            if (user != null)
            {
                if (user.UserPicture != null && user.UserPicture.Length > 0)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream(user.UserPicture))
                        {
                            pbFoto.Image = Image.FromStream(ms);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Resim yüklenirken bir hata oluştu: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcının resmi bulunamadı veya resim yolu boş.");
                }
                lblAmountDailyNum.Text = user.UserDetails.TotalCalorie.ToString() ?? "Bilinmiyor";
                lblFullNameUser.Text = user.UserDetails?.FullName ?? "Bilinmiyor";
                lblHeightUserPrfl.Text = user.UserDetails?.Height.ToString() ?? "Bilinmiyor";
                lblWeightUserPrfl.Text = user.UserDetails?.Weight.ToString() ?? "Bilinmiyor";
                lblUserGenderPrfl.Text = user.UserDetails?.Gender == true ? "Kadın" : "Erkek";

                if (user.UserDetails?.Gender == true)
                {
                    lblUserGenderPrfl.Text = "Kadın";
                }
                else if (user.UserDetails?.Gender == false)
                {
                    lblUserGenderPrfl.Text = "Erkek";
                }
                else
                {
                    lblUserGenderPrfl.Text = "Bilinmiyor";
                }

                float dailyCaloriesx = user.UserDetails?.TotalCalorie ?? 0;
                if (dailyCaloriesx < 1500)
                {
                    txtSuggestions.Text = "It seems like your caloric needs are lower than average. " +
                                          "Consider including more nutrient-dense foods like vegetables, fruits, " +
                                          "whole grains, and lean proteins into your diet.";
                }
                else if (dailyCaloriesx >= 1500 && dailyCaloriesx < 2500)
                {
                    txtSuggestions.Text = "You have a moderate caloric need. Make sure to balance your meals " +
                                          "with a good mix of carbohydrates, proteins, and fats. " +
                                          "Regular exercise is also important for your health.";
                }
                else
                {
                    txtSuggestions.Text = "Your caloric needs are higher. This might be due to high physical activity " +
                                          "or other personal factors. Ensure you're consuming enough calories to meet " +
                                          "your body's needs, especially if you're very active.";
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");
            }
        }

        private void UserProfileFrm_Load(object sender, EventArgs e)
        {


        }

        private void btnUserProfilUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog openFileDialog = new OpenFileDialog();
            //    openFileDialog.DefaultExt = "jpg";
            //    openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            //    openFileDialog.ShowDialog();
            //    string path = openFileDialog.FileName;
            //    pbFoto.Image = Image.FromFile(path);
            //    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            //}
            //catch
            //{
            //    throw new Exception("Lütfen bir resim seçiniz");
            //}
        }

        private void btnCompareReportUser_Click(object sender, EventArgs e)
        {
            UserCompareOwnReportFrm userCompareOwnReportFrm = new UserCompareOwnReportFrm(Id);
            userCompareOwnReportFrm.Show();
            this.Hide();
        }
    }
}
