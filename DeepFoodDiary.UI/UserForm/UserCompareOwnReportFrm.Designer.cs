namespace DeepFoodDiary.UI.UserForm
{
    partial class UserCompareOwnReportFrm
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
            panel1 = new Panel();
            btnKapan = new BipsControlsForms.Controls.BipsButton();
            btnMainProfil = new BipsControlsForms.Controls.BipsButton();
            pictureBox4 = new PictureBox();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            btnRaporGetir = new BipsControlsForms.Controls.BipsButton();
            dgwDay = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            dgwUserMonthlyReport = new DataGridView();
            dgwUserWeeklyReport = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtpDaily = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwDay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwUserMonthlyReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwUserWeeklyReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnKapan);
            panel1.Controls.Add(btnMainProfil);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 60);
            panel1.TabIndex = 47;
            // 
            // btnKapan
            // 
            btnKapan.BackColor = Color.FromArgb(255, 83, 73);
            btnKapan.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnKapan.BorderColor = Color.Aqua;
            btnKapan.BorderRadius = 28;
            btnKapan.BorderSize = 0;
            btnKapan.FlatAppearance.BorderSize = 0;
            btnKapan.FlatStyle = FlatStyle.Flat;
            btnKapan.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKapan.ForeColor = Color.White;
            btnKapan.Location = new Point(1222, 12);
            btnKapan.Name = "btnKapan";
            btnKapan.Size = new Size(114, 32);
            btnKapan.TabIndex = 37;
            btnKapan.Text = "Home";
            btnKapan.TextColor = Color.White;
            btnKapan.UseVisualStyleBackColor = false;
            btnKapan.Click += btnKapan_Click;
            // 
            // btnMainProfil
            // 
            btnMainProfil.BackColor = Color.FromArgb(255, 83, 73);
            btnMainProfil.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnMainProfil.BorderColor = Color.Aqua;
            btnMainProfil.BorderRadius = 28;
            btnMainProfil.BorderSize = 0;
            btnMainProfil.FlatAppearance.BorderSize = 0;
            btnMainProfil.FlatStyle = FlatStyle.Flat;
            btnMainProfil.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainProfil.ForeColor = Color.White;
            btnMainProfil.Location = new Point(1093, 12);
            btnMainProfil.Name = "btnMainProfil";
            btnMainProfil.Size = new Size(123, 32);
            btnMainProfil.TabIndex = 36;
            btnMainProfil.Text = "Main Profil";
            btnMainProfil.TextColor = Color.White;
            btnMainProfil.UseVisualStyleBackColor = false;
            btnMainProfil.Click += btnMainProfil_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(57, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // btnRaporGetir
            // 
            btnRaporGetir.BackColor = Color.Gray;
            btnRaporGetir.BackGroundColor = Color.Gray;
            btnRaporGetir.BorderColor = Color.Aqua;
            btnRaporGetir.BorderRadius = 31;
            btnRaporGetir.BorderSize = 0;
            btnRaporGetir.FlatAppearance.BorderSize = 0;
            btnRaporGetir.FlatStyle = FlatStyle.Flat;
            btnRaporGetir.ForeColor = Color.White;
            btnRaporGetir.Location = new Point(449, 586);
            btnRaporGetir.Name = "btnRaporGetir";
            btnRaporGetir.Size = new Size(447, 31);
            btnRaporGetir.TabIndex = 57;
            btnRaporGetir.Text = "Bring Reports";
            btnRaporGetir.TextColor = Color.White;
            btnRaporGetir.UseVisualStyleBackColor = false;
            btnRaporGetir.Click += btnRaporGetir_Click;
            // 
            // dgwDay
            // 
            dgwDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDay.Location = new Point(57, 158);
            dgwDay.Name = "dgwDay";
            dgwDay.RowHeadersWidth = 51;
            dgwDay.Size = new Size(328, 398);
            dgwDay.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 83, 73);
            label3.Location = new Point(57, 102);
            label3.Name = "label3";
            label3.Size = new Size(82, 16);
            label3.TabIndex = 55;
            label3.Text = "Daily Report";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 83, 73);
            label2.Location = new Point(962, 102);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 50;
            label2.Text = "Monthly Report";
            // 
            // dgwUserMonthlyReport
            // 
            dgwUserMonthlyReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUserMonthlyReport.Location = new Point(962, 121);
            dgwUserMonthlyReport.Name = "dgwUserMonthlyReport";
            dgwUserMonthlyReport.RowHeadersWidth = 51;
            dgwUserMonthlyReport.Size = new Size(316, 427);
            dgwUserMonthlyReport.TabIndex = 52;
            // 
            // dgwUserWeeklyReport
            // 
            dgwUserWeeklyReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUserWeeklyReport.Location = new Point(514, 121);
            dgwUserWeeklyReport.Name = "dgwUserWeeklyReport";
            dgwUserWeeklyReport.RowHeadersWidth = 51;
            dgwUserWeeklyReport.Size = new Size(316, 427);
            dgwUserWeeklyReport.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 83, 73);
            label1.Location = new Point(514, 102);
            label1.Name = "label1";
            label1.Size = new Size(97, 16);
            label1.TabIndex = 49;
            label1.Text = "Weekly Report";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = Properties.Resources.Sign_up_background1;
            pictureBox1.Location = new Point(939, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // dtpDaily
            // 
            dtpDaily.Location = new Point(57, 121);
            dtpDaily.Margin = new Padding(3, 2, 3, 2);
            dtpDaily.Name = "dtpDaily";
            dtpDaily.Size = new Size(195, 23);
            dtpDaily.TabIndex = 37;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = Properties.Resources.Sign_up_background1;
            pictureBox2.Location = new Point(489, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(363, 503);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = Properties.Resources.Sign_up_background1;
            pictureBox3.Location = new Point(41, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(363, 503);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 59;
            pictureBox3.TabStop = false;
            // 
            // UserCompareOwnReportFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            Controls.Add(dtpDaily);
            Controls.Add(dgwDay);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgwUserWeeklyReport);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnRaporGetir);
            Controls.Add(label2);
            Controls.Add(dgwUserMonthlyReport);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserCompareOwnReportFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwDay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwUserMonthlyReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwUserWeeklyReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private BipsControlsForms.Controls.BipsButton btnMainProfil;
        private PictureBox pictureBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private BipsControlsForms.Controls.BipsButton btnRaporGetir;
        private DataGridView dgwDay;
        private Label label3;
        private Label label2;
        private DataGridView dgwUserMonthlyReport;
        private DataGridView dgwUserWeeklyReport;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dtpDaily;
        private BipsControlsForms.Controls.BipsButton btnKapan;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}