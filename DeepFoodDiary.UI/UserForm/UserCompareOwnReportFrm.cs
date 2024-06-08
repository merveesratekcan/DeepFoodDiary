using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.UI.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFoodDiary.UI.UserForm
{
    public partial class UserCompareOwnReportFrm : KryptonForm
    {
        private readonly IUserMealFoodService _userMealFoodService;
        public int Id { get; set; }
        public UserCompareOwnReportFrm(int id)
        {
            InitializeComponent();
            _userMealFoodService = new UserMealFoodService();
            Id = id;
        }

        private void LoadWeeklyReport(int id, DateTime startDate, DateTime endDate)
        {
            var weeklyReport = _userMealFoodService.GetWeeklyMonthlyComparison(id, startDate, endDate);
            BindDataGridView(dgwUserWeeklyReport, weeklyReport);
        }


        private void LoadMonthlyReport(int id, DateTime startDate, DateTime endDate)
        {
            var monthlyReport = _userMealFoodService.GetWeeklyMonthlyComparison(id, startDate, endDate);
            BindDataGridView(dgwUserMonthlyReport, monthlyReport);
        }

        private void LoadDailyReport(int id, DateTime date)
        {
            var dailyReport = _userMealFoodService.GetDailyComparison(id, date);
            BindDataGridView(dgwDay, dailyReport);
        }

        private void BindDataGridView(DataGridView dgv, string report)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("UserID", "User ID");
            dgv.Columns.Add("UserName", "User Name");
            dgv.Columns.Add("MealName", "Meal Name");
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("Calorie", "Calorie");
            dgv.Columns.Add("Portion", "Portion");

            string[] lines = report.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 6)
                {
                    dgv.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                }
            }
        }





        private void btnMainProfil_Click(object sender, EventArgs e)
        {
            UserProfilMainFrm userMainFrm = new UserProfilMainFrm(Id);
            userMainFrm.Show();
            this.Hide();
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;

            LoadWeeklyReport(Id, startDate, endDate);
            LoadMonthlyReport(Id, startDate, endDate);
            // Günlük raporu yüklemek için bir tarih seçilmiş mi kontrol edelim
            if (dtpDaily.Value != null)
            {
                DateTime selectedDate = dtpDaily.Value;
                LoadDailyReport(Id, selectedDate);
            }
            else
            {
                MessageBox.Show("Please select a date for daily report.");
            }

        }

        private void btnKapan_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Close();
        }
    }
}
