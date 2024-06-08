namespace DeepFoodDiary.UI
{
    partial class UserProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileFrm));
            panel1 = new Panel();
            btnMainProfil = new BipsControlsForms.Controls.BipsButton();
            pictureBox4 = new PictureBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            pictureBox2 = new PictureBox();
            pbFoto = new BipsControlsForms.Controls.BipsCicularPictureBox();
            btnAddMealUser = new BipsControlsForms.Controls.BipsButton();
            btnCompareReportUser = new BipsControlsForms.Controls.BipsButton();
            pictureBox5 = new PictureBox();
            btnUserProfilUpdate = new BipsControlsForms.Controls.BipsButton();
            pictureBox1 = new PictureBox();
            lblUserFullName = new Label();
            lblUserGenderPrfl = new Label();
            lblHeightUserPrfl = new Label();
            lblWeightUserPrfl = new Label();
            pictureBox3 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            bindingSource1 = new BindingSource(components);
            txtUpdateWeight = new TextBox();
            txtUpdateHeight = new TextBox();
            btnUpdateHW = new BipsControlsForms.Controls.BipsButton();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            lblAmountDaily = new Label();
            lblAmountDailyNum = new Label();
            txtSuggestions = new TextBox();
            pictureBox12 = new PictureBox();
            lblFullNameUser = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMainProfil);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 60);
            panel1.TabIndex = 33;
            // 
            // btnMainProfil
            // 
            btnMainProfil.BackColor = Color.FromArgb(255, 83, 73);
            btnMainProfil.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnMainProfil.BackgroundImageLayout = ImageLayout.None;
            btnMainProfil.BorderColor = Color.Aqua;
            btnMainProfil.BorderRadius = 28;
            btnMainProfil.BorderSize = 0;
            btnMainProfil.FlatAppearance.BorderSize = 0;
            btnMainProfil.FlatStyle = FlatStyle.Flat;
            btnMainProfil.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainProfil.ForeColor = Color.White;
            btnMainProfil.Location = new Point(1191, 12);
            btnMainProfil.Name = "btnMainProfil";
            btnMainProfil.Size = new Size(111, 32);
            btnMainProfil.TabIndex = 72;
            btnMainProfil.Text = "Main Profil";
            btnMainProfil.TextColor = Color.White;
            btnMainProfil.UseVisualStyleBackColor = false;
            btnMainProfil.Click += btnMainProfil_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(86, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(355, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(981, 521);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pbFoto
            // 
            pbFoto.BoderSize = 2;
            pbFoto.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbFoto.BorderColor = Color.FromArgb(255, 192, 128);
            pbFoto.BorderColor2 = Color.Red;
            pbFoto.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbFoto.GradienteAngle = 50F;
            pbFoto.Location = new Point(142, 89);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(123, 128);
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoto.TabIndex = 36;
            pbFoto.TabStop = false;
            // 
            // btnAddMealUser
            // 
            btnAddMealUser.BackColor = Color.YellowGreen;
            btnAddMealUser.BackGroundColor = Color.YellowGreen;
            btnAddMealUser.BackgroundImageLayout = ImageLayout.None;
            btnAddMealUser.BorderColor = Color.Aqua;
            btnAddMealUser.BorderRadius = 40;
            btnAddMealUser.BorderSize = 0;
            btnAddMealUser.FlatAppearance.BorderSize = 0;
            btnAddMealUser.FlatStyle = FlatStyle.Flat;
            btnAddMealUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMealUser.ForeColor = Color.White;
            btnAddMealUser.Location = new Point(468, 89);
            btnAddMealUser.Name = "btnAddMealUser";
            btnAddMealUser.Size = new Size(150, 40);
            btnAddMealUser.TabIndex = 37;
            btnAddMealUser.Text = "Add Meal";
            btnAddMealUser.TextColor = Color.White;
            btnAddMealUser.UseVisualStyleBackColor = false;
            btnAddMealUser.Click += btnAddMealUser_Click;
            // 
            // btnCompareReportUser
            // 
            btnCompareReportUser.BackColor = Color.White;
            btnCompareReportUser.BackGroundColor = Color.White;
            btnCompareReportUser.BorderColor = Color.Aqua;
            btnCompareReportUser.BorderRadius = 40;
            btnCompareReportUser.BorderSize = 0;
            btnCompareReportUser.FlatAppearance.BorderSize = 0;
            btnCompareReportUser.FlatStyle = FlatStyle.Flat;
            btnCompareReportUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompareReportUser.ForeColor = Color.YellowGreen;
            btnCompareReportUser.Location = new Point(1075, 89);
            btnCompareReportUser.Name = "btnCompareReportUser";
            btnCompareReportUser.Size = new Size(150, 50);
            btnCompareReportUser.TabIndex = 38;
            btnCompareReportUser.Text = "Compare Report";
            btnCompareReportUser.TextColor = Color.YellowGreen;
            btnCompareReportUser.UseVisualStyleBackColor = false;
            btnCompareReportUser.Click += btnCompareReportUser_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = Properties.Resources.report;
            pictureBox5.Location = new Point(1012, 89);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 40;
            pictureBox5.TabStop = false;
            // 
            // btnUserProfilUpdate
            // 
            btnUserProfilUpdate.BackColor = Color.White;
            btnUserProfilUpdate.BackGroundColor = Color.White;
            btnUserProfilUpdate.BackgroundImage = Properties.Resources.edit;
            btnUserProfilUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUserProfilUpdate.BorderColor = Color.Aqua;
            btnUserProfilUpdate.BorderRadius = 40;
            btnUserProfilUpdate.BorderSize = 0;
            btnUserProfilUpdate.FlatAppearance.BorderSize = 0;
            btnUserProfilUpdate.FlatStyle = FlatStyle.Flat;
            btnUserProfilUpdate.ForeColor = Color.White;
            btnUserProfilUpdate.Location = new Point(296, 99);
            btnUserProfilUpdate.Name = "btnUserProfilUpdate";
            btnUserProfilUpdate.Size = new Size(42, 40);
            btnUserProfilUpdate.TabIndex = 45;
            btnUserProfilUpdate.TextColor = Color.White;
            btnUserProfilUpdate.UseVisualStyleBackColor = false;
            btnUserProfilUpdate.Click += btnUserProfilUpdate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profil_background;
            pictureBox1.Location = new Point(40, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // lblUserFullName
            // 
            lblUserFullName.AutoSize = true;
            lblUserFullName.BackColor = Color.White;
            lblUserFullName.Location = new Point(803, 277);
            lblUserFullName.Name = "lblUserFullName";
            lblUserFullName.Size = new Size(0, 15);
            lblUserFullName.TabIndex = 48;
            // 
            // lblUserGenderPrfl
            // 
            lblUserGenderPrfl.AutoSize = true;
            lblUserGenderPrfl.BackColor = Color.White;
            lblUserGenderPrfl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserGenderPrfl.ForeColor = Color.FromArgb(64, 64, 64);
            lblUserGenderPrfl.Location = new Point(177, 308);
            lblUserGenderPrfl.Name = "lblUserGenderPrfl";
            lblUserGenderPrfl.Size = new Size(16, 16);
            lblUserGenderPrfl.TabIndex = 49;
            lblUserGenderPrfl.Text = "...";
            // 
            // lblHeightUserPrfl
            // 
            lblHeightUserPrfl.AutoSize = true;
            lblHeightUserPrfl.BackColor = Color.White;
            lblHeightUserPrfl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeightUserPrfl.ForeColor = Color.Black;
            lblHeightUserPrfl.Location = new Point(177, 366);
            lblHeightUserPrfl.Name = "lblHeightUserPrfl";
            lblHeightUserPrfl.Size = new Size(16, 16);
            lblHeightUserPrfl.TabIndex = 50;
            lblHeightUserPrfl.Text = "...";
            // 
            // lblWeightUserPrfl
            // 
            lblWeightUserPrfl.AutoSize = true;
            lblWeightUserPrfl.BackColor = Color.White;
            lblWeightUserPrfl.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeightUserPrfl.ForeColor = Color.FromArgb(64, 64, 64);
            lblWeightUserPrfl.Location = new Point(177, 437);
            lblWeightUserPrfl.Name = "lblWeightUserPrfl";
            lblWeightUserPrfl.Size = new Size(16, 16);
            lblWeightUserPrfl.TabIndex = 51;
            lblWeightUserPrfl.Text = "...";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.kg;
            pictureBox3.Location = new Point(130, 415);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Properties.Resources.lenght;
            pictureBox6.Location = new Point(130, 348);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 54;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Properties.Resources.Gender;
            pictureBox7.Location = new Point(130, 291);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(41, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 55;
            pictureBox7.TabStop = false;
            // 
            // txtUpdateWeight
            // 
            txtUpdateWeight.Location = new Point(177, 507);
            txtUpdateWeight.Name = "txtUpdateWeight";
            txtUpdateWeight.Size = new Size(139, 23);
            txtUpdateWeight.TabIndex = 58;
            // 
            // txtUpdateHeight
            // 
            txtUpdateHeight.Location = new Point(177, 477);
            txtUpdateHeight.Name = "txtUpdateHeight";
            txtUpdateHeight.Size = new Size(139, 23);
            txtUpdateHeight.TabIndex = 59;
            // 
            // btnUpdateHW
            // 
            btnUpdateHW.BackColor = Color.FromArgb(255, 83, 73);
            btnUpdateHW.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnUpdateHW.BackgroundImageLayout = ImageLayout.None;
            btnUpdateHW.BorderColor = Color.Aqua;
            btnUpdateHW.BorderRadius = 28;
            btnUpdateHW.BorderSize = 0;
            btnUpdateHW.FlatAppearance.BorderSize = 0;
            btnUpdateHW.FlatStyle = FlatStyle.Flat;
            btnUpdateHW.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateHW.ForeColor = Color.White;
            btnUpdateHW.Location = new Point(177, 557);
            btnUpdateHW.Name = "btnUpdateHW";
            btnUpdateHW.Size = new Size(111, 28);
            btnUpdateHW.TabIndex = 60;
            btnUpdateHW.Text = "Update";
            btnUpdateHW.TextColor = Color.White;
            btnUpdateHW.UseVisualStyleBackColor = false;
            btnUpdateHW.Click += btnUpdateHW_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.White;
            pictureBox8.Image = Properties.Resources.lenght;
            pictureBox8.Location = new Point(130, 477);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 23);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 61;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.White;
            pictureBox9.Image = Properties.Resources.kg;
            pictureBox9.Location = new Point(130, 507);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 23);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 62;
            pictureBox9.TabStop = false;
            // 
            // lblAmountDaily
            // 
            lblAmountDaily.AutoSize = true;
            lblAmountDaily.BackColor = Color.White;
            lblAmountDaily.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountDaily.ForeColor = Color.FromArgb(255, 83, 73);
            lblAmountDaily.Location = new Point(468, 183);
            lblAmountDaily.Name = "lblAmountDaily";
            lblAmountDaily.Size = new Size(279, 15);
            lblAmountDaily.TabIndex = 63;
            lblAmountDaily.Text = "The amount of calories you should consume daily;";
            // 
            // lblAmountDailyNum
            // 
            lblAmountDailyNum.AutoSize = true;
            lblAmountDailyNum.BackColor = Color.White;
            lblAmountDailyNum.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmountDailyNum.Location = new Point(782, 180);
            lblAmountDailyNum.Name = "lblAmountDailyNum";
            lblAmountDailyNum.Size = new Size(21, 20);
            lblAmountDailyNum.TabIndex = 64;
            lblAmountDailyNum.Text = "...";
            // 
            // txtSuggestions
            // 
            txtSuggestions.Location = new Point(468, 264);
            txtSuggestions.Multiline = true;
            txtSuggestions.Name = "txtSuggestions";
            txtSuggestions.Size = new Size(368, 297);
            txtSuggestions.TabIndex = 68;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.White;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(859, 264);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(381, 297);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 98;
            pictureBox12.TabStop = false;
            // 
            // lblFullNameUser
            // 
            lblFullNameUser.AutoSize = true;
            lblFullNameUser.BackColor = Color.White;
            lblFullNameUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullNameUser.ForeColor = Color.Black;
            lblFullNameUser.Location = new Point(130, 248);
            lblFullNameUser.Name = "lblFullNameUser";
            lblFullNameUser.Size = new Size(16, 16);
            lblFullNameUser.TabIndex = 99;
            lblFullNameUser.Text = "...";
            // 
            // UserProfileFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            Controls.Add(lblFullNameUser);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(btnAddMealUser);
            Controls.Add(btnUpdateHW);
            Controls.Add(txtUpdateHeight);
            Controls.Add(txtUpdateWeight);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox3);
            Controls.Add(lblWeightUserPrfl);
            Controls.Add(lblHeightUserPrfl);
            Controls.Add(lblUserGenderPrfl);
            Controls.Add(lblUserFullName);
            Controls.Add(btnUserProfilUpdate);
            Controls.Add(pbFoto);
            Controls.Add(pictureBox12);
            Controls.Add(txtSuggestions);
            Controls.Add(lblAmountDailyNum);
            Controls.Add(lblAmountDaily);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(btnCompareReportUser);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "UserProfileFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            Load += UserProfileFrm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private PictureBox pictureBox2;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFoto;
        private BipsControlsForms.Controls.BipsButton btnAddMealUser;
        private BipsControlsForms.Controls.BipsButton btnCompareReportUser;
        private PictureBox pictureBox5;
        private BipsControlsForms.Controls.BipsButton btnUserProfilUpdate;
        private PictureBox pictureBox1;
        private Label lblUserFullName;
        private Label lblUserGenderPrfl;
        private Label lblHeightUserPrfl;
        private Label lblWeightUserPrfl;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private BindingSource bindingSource1;
        private TextBox txtUpdateWeight;
        private TextBox txtUpdateHeight;
        private BipsControlsForms.Controls.BipsButton btnUpdateHW;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label lblAmountDaily;
        private Label lblAmountDailyNum;
        private BipsControlsForms.Controls.BipsButton btnMainProfil;
        private TextBox txtSuggestions;
        private PictureBox pictureBox12;
        private Label lblFullNameUser;
    }
}