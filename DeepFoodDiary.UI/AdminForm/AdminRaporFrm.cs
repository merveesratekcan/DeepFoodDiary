using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
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
    public partial class AdminRaporFrm : KryptonForm
    {
        private readonly IUserMealFoodService _userMealFoodService;
        public AdminRaporFrm()
        {
            InitializeComponent();
            _userMealFoodService = new UserMealFoodService();
        }


        private void LoadWeeklyReport()
        {
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            var weeklyReport = _userMealFoodService.GetWeeklyMonthlyComparison(startDate, endDate);
            BindDataGridView(dgw_Weekly, weeklyReport);
        }

        private void LoadMonthlyReport()
        {
            DateTime startDate = DateTime.Now.AddMonths(-1);
            DateTime endDate = DateTime.Now;
            var monthlyReport = _userMealFoodService.GetWeeklyMonthlyComparison(startDate, endDate);
            BindDataGridView(dgwMonthly, monthlyReport);
        }

        private void BindDataGridView(DataGridView dgv, string report)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            dgv.Columns.Add("UserID", "User ID");
            dgv.Columns.Add("UserName", "User Name");
            dgv.Columns.Add("MealName", "Meal Name");
            dgv.Columns.Add("Year", "Year");
            dgv.Columns.Add("Week", "Week");
            dgv.Columns.Add("TotalCalories", "Total Calories");

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

        private void btn_RaporGetir_Click_1(object sender, EventArgs e)
        {
            LoadWeeklyReport();
            LoadMonthlyReport();
            DateTime startDate = DateTime.Now.AddDays(-7);
            DateTime endDate = DateTime.Now;
            string mealConsumptionReport = _userMealFoodService.GetMealConsumptionReport(startDate, endDate);
            DisplayFoodReport(mealConsumptionReport);

            string mealPortionReport = _userMealFoodService.GetMealPortion(startDate, endDate);
            txtMealPortion.Text = mealPortionReport;

        }


        private void DisplayFoodReport(string report)
        {

            txtReport.Text = report;
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            AddCategoryFrm addCategoryFrm = new AddCategoryFrm();
            addCategoryFrm.Show();
            this.Hide();
        }

        private void txtMealPortion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
