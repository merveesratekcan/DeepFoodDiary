using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DeepFoodDiary.UI.UserForm
{
    public partial class ForgetPasswordFrm : KryptonForm
    {
        private readonly IUserService _userService;
        public ForgetPasswordFrm()
        {
            InitializeComponent();
            _userService = new UserService();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginFrm userloginFrm = new UserLoginFrm();
            userloginFrm.Show();
            this.Hide();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            int userId = _userService.GetAll().FirstOrDefault(x => x.SecurityCode == txtNewPassCode.Text)?.Id ?? 0;
            var pass = _userService.HashPassword(txtNewPass.Text);

            if (userId != 0)
            {
                User user = _userService.GetById(userId);
                user.UserName = txtNewPassEmail.Text;
                user.Password = pass;
                user.SecurityCode = txtNewPassCode.Text;

                _userService.Update(user);
                MessageBox.Show("Bilgileriniz başarıyla güncellendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı veya geçerli bir Id değeri alınamadı.");
            }
        }
    }
}
