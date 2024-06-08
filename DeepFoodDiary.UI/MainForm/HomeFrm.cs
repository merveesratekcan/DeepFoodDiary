using ComponentFactory.Krypton.Toolkit;
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

namespace DeepFoodDiary.UI.MainForm
{
    public partial class HomeFrm : KryptonForm
    {
        public HomeFrm()
        {
            InitializeComponent();
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            UserRegisterFrm userRegisterFrm = new UserRegisterFrm();
            userRegisterFrm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginFrm userLoginFrm = new UserLoginFrm();
            userLoginFrm.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUsFrm aboutUsFrm = new AboutUsFrm();
            aboutUsFrm.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminLoginFrm adminLoginFrm = new AdminLoginFrm();
            adminLoginFrm.Show();
            this.Hide();
        }
    }
}
