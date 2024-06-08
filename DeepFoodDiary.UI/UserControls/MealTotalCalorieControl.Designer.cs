namespace DeepFoodDiary.UI.UserForm
{
    partial class MealTotalCalorieControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMealName = new Label();
            lblMealCalorie = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblMealName.Location = new Point(35, 47);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(115, 25);
            lblMealName.TabIndex = 29;
            lblMealName.Text = "MealName";
            // 
            // lblMealCalorie
            // 
            lblMealCalorie.AutoSize = true;
            lblMealCalorie.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblMealCalorie.Location = new Point(156, 47);
            lblMealCalorie.Name = "lblMealCalorie";
            lblMealCalorie.Size = new Size(81, 25);
            lblMealCalorie.TabIndex = 30;
            lblMealCalorie.Text = "Calorie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(243, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 31;
            label1.Text = "cal";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lblMealCalorie);
            Controls.Add(lblMealName);
            Name = "UserControl1";
            Size = new Size(438, 147);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMealName;
        private Label lblMealCalorie;
        private Label label1;
    }
}
