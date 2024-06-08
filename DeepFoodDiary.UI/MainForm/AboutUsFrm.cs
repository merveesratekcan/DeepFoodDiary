using ComponentFactory.Krypton.Toolkit;
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
    public partial class AboutUsFrm : KryptonForm
    {
        public AboutUsFrm()
        {
            InitializeComponent();
            
        }
    
      

        private void bipsButton1_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Hide();
        }
    }
}
