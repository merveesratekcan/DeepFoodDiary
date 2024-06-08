using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.UI.CategoryForm;
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
    public partial class UserProfilMainFrm : KryptonForm
    {
        public int Id {  get; set; }
        public UserProfilMainFrm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void bips_Click(object sender, EventArgs e)
        {
            UserAddMealFrm userAddMealFrm = new UserAddMealFrm(Id);
            userAddMealFrm.Show();
            this.Hide();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            UserProfileFrm userProfilFrm = new UserProfileFrm(Id);
            
            userProfilFrm.Show();
            this.Hide();
        }
    }
}
