namespace DeepFoodDiary.UI
{
    partial class AdminRaporFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgw_Weekly = new DataGridView();
            dgwMonthly = new DataGridView();
            btn_RaporGetir = new BipsControlsForms.Controls.BipsButton();
            label5 = new Label();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            label2 = new Label();
            pbFood = new BipsControlsForms.Controls.BipsCicularPictureBox();
            txtReport = new TextBox();
            txtMealPortion = new TextBox();
            btnNext = new BipsControlsForms.Controls.BipsButton();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgw_Weekly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwMonthly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            SuspendLayout();
            // 
            // dgw_Weekly
            // 
            dgw_Weekly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Weekly.Location = new Point(392, 133);
            dgw_Weekly.Margin = new Padding(3, 2, 3, 2);
            dgw_Weekly.MultiSelect = false;
            dgw_Weekly.Name = "dgw_Weekly";
            dgw_Weekly.ReadOnly = true;
            dgw_Weekly.RowHeadersWidth = 51;
            dgw_Weekly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Weekly.Size = new Size(377, 407);
            dgw_Weekly.TabIndex = 0;
            // 
            // dgwMonthly
            // 
            dgwMonthly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMonthly.Location = new Point(12, 133);
            dgwMonthly.Margin = new Padding(3, 2, 3, 2);
            dgwMonthly.Name = "dgwMonthly";
            dgwMonthly.RowHeadersWidth = 51;
            dgwMonthly.Size = new Size(374, 407);
            dgwMonthly.TabIndex = 1;
            // 
            // btn_RaporGetir
            // 
            btn_RaporGetir.BackColor = Color.FromArgb(64, 64, 64);
            btn_RaporGetir.BackGroundColor = Color.FromArgb(64, 64, 64);
            btn_RaporGetir.BorderColor = Color.Aqua;
            btn_RaporGetir.BorderRadius = 40;
            btn_RaporGetir.BorderSize = 0;
            btn_RaporGetir.FlatAppearance.BorderSize = 0;
            btn_RaporGetir.FlatStyle = FlatStyle.Flat;
            btn_RaporGetir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_RaporGetir.ForeColor = Color.White;
            btn_RaporGetir.Location = new Point(503, 577);
            btn_RaporGetir.Name = "btn_RaporGetir";
            btn_RaporGetir.Size = new Size(380, 40);
            btn_RaporGetir.TabIndex = 3;
            btn_RaporGetir.Text = "Bring Reports";
            btn_RaporGetir.TextColor = Color.White;
            btn_RaporGetir.UseVisualStyleBackColor = false;
            btn_RaporGetir.Click += btn_RaporGetir_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(621, 17);
            label5.Name = "label5";
            label5.Size = new Size(120, 24);
            label5.TabIndex = 26;
            label5.Text = "Preport Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(255, 83, 73);
            label2.Location = new Point(81, 21);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 34;
            label2.Text = "Admin Panel";
            // 
            // pbFood
            // 
            pbFood.BoderSize = 2;
            pbFood.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbFood.BorderColor = Color.Red;
            pbFood.BorderColor2 = Color.FromArgb(255, 224, 192);
            pbFood.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbFood.GradienteAngle = 50F;
            pbFood.Image = Properties.Resources.Group_2;
            pbFood.Location = new Point(12, 6);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(63, 62);
            pbFood.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFood.TabIndex = 33;
            pbFood.TabStop = false;
            // 
            // txtReport
            // 
            txtReport.Location = new Point(775, 133);
            txtReport.Margin = new Padding(3, 2, 3, 2);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.Size = new Size(215, 407);
            txtReport.TabIndex = 59;
            // 
            // txtMealPortion
            // 
            txtMealPortion.Location = new Point(996, 133);
            txtMealPortion.Margin = new Padding(3, 2, 3, 2);
            txtMealPortion.Multiline = true;
            txtMealPortion.Name = "txtMealPortion";
            txtMealPortion.Size = new Size(320, 407);
            txtMealPortion.TabIndex = 60;
            txtMealPortion.TextChanged += txtMealPortion_TextChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Silver;
            btnNext.BackGroundColor = Color.Silver;
            btnNext.BorderColor = Color.Aqua;
            btnNext.BorderRadius = 31;
            btnNext.BorderSize = 0;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Transparent;
            btnNext.Location = new Point(1217, 586);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(119, 31);
            btnNext.TabIndex = 62;
            btnNext.Text = "Next";
            btnNext.TextColor = Color.Transparent;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 63;
            label1.Text = "Daily Report:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.YellowGreen;
            label3.Location = new Point(392, 111);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 64;
            label3.Text = "Monthly Report:";
            // 
            // AdminRaporFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 629);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnNext);
            Controls.Add(txtMealPortion);
            Controls.Add(txtReport);
            Controls.Add(label2);
            Controls.Add(pbFood);
            Controls.Add(label5);
            Controls.Add(btn_RaporGetir);
            Controls.Add(dgwMonthly);
            Controls.Add(dgw_Weekly);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminRaporFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)dgw_Weekly).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwMonthly).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_Weekly;
        private DataGridView dgwMonthly;
        private BipsControlsForms.Controls.BipsButton btn_RaporGetir;
        private Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label2;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFood;
        private TextBox txtReport;
        private TextBox txtMealPortion;
        private BipsControlsForms.Controls.BipsButton btnNext;
        private Label label1;
        private Label label3;
    }
}