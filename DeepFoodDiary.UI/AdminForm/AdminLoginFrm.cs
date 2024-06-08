using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.UI.MainForm;


namespace DeepFoodDiary.UI
{
    public partial class AdminLoginFrm : KryptonForm
    {
        private readonly IAdminService _adminService;
        public AdminLoginFrm()
        {
            InitializeComponent();
            _adminService = new AdminService();
        }


        private void btn_Login_Click_1(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ býrakýlamaz.");
                return;
            }

            if (_adminService.LogIn(username, password))
            {

                MessageBox.Show("giriþ baþarýlý");
                AdminRaporFrm adminRaporFrm = new AdminRaporFrm();
                adminRaporFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanýcý adý veya þifre hatalý");
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Hide();
        }
    }
}
