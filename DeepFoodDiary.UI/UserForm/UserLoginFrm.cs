using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.DAL.Repositories;
using DeepFoodDiary.DAL.RepositoryInterface;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.UI.CategoryForm;
using DeepFoodDiary.UI.MainForm;
using DeepFoodDiary.UI.UserForm;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using KryptonForm = ComponentFactory.Krypton.Toolkit.KryptonForm;

namespace DeepFoodDiary.UI
{
    public partial class UserLoginFrm : KryptonForm
    {
        private readonly IUserService _userService;
        public UserLoginFrm()
        {
            InitializeComponent();

            _userService = new UserService();
        }

        private void btn_Login_Click_1(object sender, EventArgs e)
        {

            string email = txtUsername.Text;
            string password = (txtUserPassword.Text);



            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }
            User user = _userService.Login(email, password);
            if (user != null)
            {

                MessageBox.Show("giriş başarılı");
                
                UserProfileFrm userProfileFrm = new UserProfileFrm(user.Id);

                userProfileFrm.Show();


                //UserAddMealFrm userAddMealFrm = new UserAddMealFrm(user.Id);
                //userAddMealFrm.ShowDialog();


                //UserCompareOwnReportFrm userCompareOwnReportFrm = new UserCompareOwnReportFrm(user.Id);
                //userCompareOwnReportFrm.ShowDialog();



                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
                txtUsername.Clear();
                txtUserPassword.Clear();
            }
        }





        private void btnSingUp_Click(object sender, EventArgs e)
        {
            UserRegisterFrm userRegisterFrm = new UserRegisterFrm();
            userRegisterFrm.ShowDialog();
            this.Hide();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            UserRegisterFrm userRegisterFrm = new UserRegisterFrm();
            userRegisterFrm.ShowDialog();
            this.Hide();
        }

        private void btnEye_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.PasswordChar == '*')
            {
                txtUserPassword.PasswordChar = '\0';  // Şifreyi göster (PasswordChar'ı sıfırla)
            }
            else
            {
                txtUserPassword.PasswordChar = '*';  // Şifreyi gizle (PasswordChar'ı '*' yap)
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPasswordFrm forgetPassFrm = new ForgetPasswordFrm();
            forgetPassFrm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Hide();
        }

        private void UserLoginFrm_Load(object sender, EventArgs e)
        {
            this.AutoSize = true; // Otomatik boyutlandırma etkinleştirildi
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; // İçeriğe göre büyütme ve küçültme
        }
    }
}
