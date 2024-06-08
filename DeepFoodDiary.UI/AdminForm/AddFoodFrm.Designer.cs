namespace DeepFoodDiary.UI
{
    partial class btnGoHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnGoHome));
            dgw_Food = new DataGridView();
            txt_FoodName = new TextBox();
            cmsFood = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            txtKarbonhidrat = new TextBox();
            txtYağ = new TextBox();
            cmbFoodCategory = new ComboBox();
            btnFoodAdd = new BipsControlsForms.Controls.BipsButton();
            btn_FoodUpdate = new BipsControlsForms.Controls.BipsButton();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            pbFood = new BipsControlsForms.Controls.BipsCicularPictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new BipsControlsForms.Controls.BipsButton();
            btnForward = new BipsControlsForms.Controls.BipsButton();
            btnÜrünFotoEkle = new BipsControlsForms.Controls.BipsButton();
            nudFoodCalorie = new NumericUpDown();
            txtProtein = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            bipsCicularPictureBox1 = new BipsControlsForms.Controls.BipsCicularPictureBox();
            pbFood2 = new BipsControlsForms.Controls.BipsCicularPictureBox();
            bipsButton1 = new BipsControlsForms.Controls.BipsButton();
            ((System.ComponentModel.ISupportInitialize)dgw_Food).BeginInit();
            cmsFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodCalorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bipsCicularPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFood2).BeginInit();
            SuspendLayout();
            // 
            // dgw_Food
            // 
            dgw_Food.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Food.Location = new Point(617, 51);
            dgw_Food.Margin = new Padding(3, 2, 3, 2);
            dgw_Food.MultiSelect = false;
            dgw_Food.Name = "dgw_Food";
            dgw_Food.ReadOnly = true;
            dgw_Food.RowHeadersWidth = 51;
            dgw_Food.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Food.Size = new Size(563, 510);
            dgw_Food.TabIndex = 11;
            // 
            // txt_FoodName
            // 
            txt_FoodName.BackColor = Color.Silver;
            txt_FoodName.Location = new Point(322, 232);
            txt_FoodName.Margin = new Padding(3, 2, 3, 2);
            txt_FoodName.Multiline = true;
            txt_FoodName.Name = "txt_FoodName";
            txt_FoodName.Size = new Size(231, 26);
            txt_FoodName.TabIndex = 9;
            // 
            // cmsFood
            // 
            cmsFood.Font = new Font("Segoe UI", 9F);
            cmsFood.ImageScalingSize = new Size(20, 20);
            cmsFood.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
            cmsFood.Name = "contextMenuStrip1";
            cmsFood.Size = new Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(120, 22);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(120, 22);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // txtKarbonhidrat
            // 
            txtKarbonhidrat.BackColor = Color.Silver;
            txtKarbonhidrat.Location = new Point(322, 405);
            txtKarbonhidrat.Margin = new Padding(3, 2, 3, 2);
            txtKarbonhidrat.Multiline = true;
            txtKarbonhidrat.Name = "txtKarbonhidrat";
            txtKarbonhidrat.Size = new Size(231, 28);
            txtKarbonhidrat.TabIndex = 14;
            // 
            // txtYağ
            // 
            txtYağ.BackColor = Color.Silver;
            txtYağ.Location = new Point(322, 452);
            txtYağ.Margin = new Padding(3, 2, 3, 2);
            txtYağ.Multiline = true;
            txtYağ.Name = "txtYağ";
            txtYağ.Size = new Size(231, 25);
            txtYağ.TabIndex = 15;
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.BackColor = Color.Silver;
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(322, 274);
            cmbFoodCategory.Margin = new Padding(3, 2, 3, 2);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(231, 23);
            cmbFoodCategory.TabIndex = 17;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnFoodAdd.BackGroundColor = Color.FromArgb(64, 64, 64);
            btnFoodAdd.BorderColor = Color.Aqua;
            btnFoodAdd.BorderRadius = 26;
            btnFoodAdd.BorderSize = 0;
            btnFoodAdd.FlatAppearance.BorderSize = 0;
            btnFoodAdd.FlatStyle = FlatStyle.Flat;
            btnFoodAdd.ForeColor = Color.White;
            btnFoodAdd.Location = new Point(226, 503);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(260, 26);
            btnFoodAdd.TabIndex = 18;
            btnFoodAdd.Text = "Add";
            btnFoodAdd.TextColor = Color.White;
            btnFoodAdd.UseVisualStyleBackColor = false;
            btnFoodAdd.Click += btnFoodAdd_Click_1;
            // 
            // btn_FoodUpdate
            // 
            btn_FoodUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btn_FoodUpdate.BackGroundColor = Color.FromArgb(64, 64, 64);
            btn_FoodUpdate.BorderColor = Color.Aqua;
            btn_FoodUpdate.BorderRadius = 26;
            btn_FoodUpdate.BorderSize = 0;
            btn_FoodUpdate.FlatAppearance.BorderSize = 0;
            btn_FoodUpdate.FlatStyle = FlatStyle.Flat;
            btn_FoodUpdate.ForeColor = Color.White;
            btn_FoodUpdate.Location = new Point(226, 535);
            btn_FoodUpdate.Name = "btn_FoodUpdate";
            btn_FoodUpdate.Size = new Size(260, 26);
            btn_FoodUpdate.TabIndex = 19;
            btn_FoodUpdate.Text = "Update";
            btn_FoodUpdate.TextColor = Color.White;
            btn_FoodUpdate.UseVisualStyleBackColor = false;
            btn_FoodUpdate.Click += btn_FoodUpdate_Click_1;
            // 
            // pbFood
            // 
            pbFood.BoderSize = 2;
            pbFood.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbFood.BorderColor = Color.Gray;
            pbFood.BorderColor2 = Color.RoyalBlue;
            pbFood.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbFood.GradienteAngle = 50F;
            pbFood.Image = (Image)resources.GetObject("pbFood.Image");
            pbFood.Location = new Point(322, 129);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(95, 98);
            pbFood.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFood.TabIndex = 20;
            pbFood.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 235);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 21;
            label1.Text = "Food Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 282);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 22;
            label2.Text = "Food Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 418);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 23;
            label3.Text = "Oil Value:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(189, 456);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 24;
            label4.Text = "Carbohydrate Value:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 83);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 25;
            label5.Text = "Add Or Update Food";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_75;
            pictureBox1.Location = new Point(155, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 510);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.BackGroundColor = Color.Silver;
            btnBack.BorderColor = Color.Aqua;
            btnBack.BorderRadius = 31;
            btnBack.BorderSize = 0;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(10, 574);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 31);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.Transparent;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.Silver;
            btnForward.BackGroundColor = Color.Silver;
            btnForward.BorderColor = Color.Aqua;
            btnForward.BorderRadius = 31;
            btnForward.BorderSize = 0;
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForward.ForeColor = Color.Transparent;
            btnForward.Location = new Point(1217, 574);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(119, 31);
            btnForward.TabIndex = 30;
            btnForward.Text = "Next";
            btnForward.TextColor = Color.Transparent;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // btnÜrünFotoEkle
            // 
            btnÜrünFotoEkle.BackColor = Color.FromArgb(64, 64, 64);
            btnÜrünFotoEkle.BackGroundColor = Color.FromArgb(64, 64, 64);
            btnÜrünFotoEkle.BorderColor = Color.Aqua;
            btnÜrünFotoEkle.BorderRadius = 26;
            btnÜrünFotoEkle.BorderSize = 0;
            btnÜrünFotoEkle.FlatAppearance.BorderSize = 0;
            btnÜrünFotoEkle.FlatStyle = FlatStyle.Flat;
            btnÜrünFotoEkle.ForeColor = Color.White;
            btnÜrünFotoEkle.Location = new Point(423, 169);
            btnÜrünFotoEkle.Name = "btnÜrünFotoEkle";
            btnÜrünFotoEkle.Size = new Size(121, 29);
            btnÜrünFotoEkle.TabIndex = 31;
            btnÜrünFotoEkle.Text = "Add Photo";
            btnÜrünFotoEkle.TextColor = Color.White;
            btnÜrünFotoEkle.UseVisualStyleBackColor = false;
            btnÜrünFotoEkle.Click += btnÜrünFotoEkle_Click_1;
            // 
            // nudFoodCalorie
            // 
            nudFoodCalorie.BackColor = Color.Silver;
            nudFoodCalorie.Location = new Point(322, 321);
            nudFoodCalorie.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFoodCalorie.Name = "nudFoodCalorie";
            nudFoodCalorie.Size = new Size(231, 23);
            nudFoodCalorie.TabIndex = 32;
            // 
            // txtProtein
            // 
            txtProtein.BackColor = Color.Silver;
            txtProtein.Location = new Point(322, 358);
            txtProtein.Margin = new Padding(3, 2, 3, 2);
            txtProtein.Multiline = true;
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(231, 30);
            txtProtein.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 329);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 34;
            label6.Text = "Food Calory:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(189, 169);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 35;
            label7.Text = "Food Photo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(189, 373);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 36;
            label8.Text = "Protein Value:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label9.ForeColor = Color.FromArgb(255, 83, 73);
            label9.Location = new Point(60, 15);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 38;
            label9.Text = "Admin Panel";
            // 
            // bipsCicularPictureBox1
            // 
            bipsCicularPictureBox1.BoderSize = 2;
            bipsCicularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            bipsCicularPictureBox1.BorderColor = Color.Red;
            bipsCicularPictureBox1.BorderColor2 = Color.FromArgb(255, 224, 192);
            bipsCicularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            bipsCicularPictureBox1.GradienteAngle = 50F;
            bipsCicularPictureBox1.Image = Properties.Resources.Group_2;
            bipsCicularPictureBox1.Location = new Point(-1, 2);
            bipsCicularPictureBox1.Name = "bipsCicularPictureBox1";
            bipsCicularPictureBox1.Size = new Size(55, 57);
            bipsCicularPictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            bipsCicularPictureBox1.TabIndex = 37;
            bipsCicularPictureBox1.TabStop = false;
            // 
            // pbFood2
            // 
            pbFood2.BoderSize = 2;
            pbFood2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pbFood2.BorderColor = Color.FromArgb(255, 192, 192);
            pbFood2.BorderColor2 = Color.FromArgb(255, 192, 192);
            pbFood2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pbFood2.GradienteAngle = 50F;
            pbFood2.Image = Properties.Resources.Sweet;
            pbFood2.Location = new Point(322, 127);
            pbFood2.Name = "pbFood2";
            pbFood2.Size = new Size(100, 100);
            pbFood2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFood2.TabIndex = 39;
            pbFood2.TabStop = false;
            // 
            // bipsButton1
            // 
            bipsButton1.BackColor = Color.YellowGreen;
            bipsButton1.BackGroundColor = Color.YellowGreen;
            bipsButton1.BorderColor = Color.Aqua;
            bipsButton1.BorderRadius = 31;
            bipsButton1.BorderSize = 0;
            bipsButton1.FlatAppearance.BorderSize = 0;
            bipsButton1.FlatStyle = FlatStyle.Flat;
            bipsButton1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bipsButton1.ForeColor = Color.Transparent;
            bipsButton1.Location = new Point(1217, 15);
            bipsButton1.Name = "bipsButton1";
            bipsButton1.Size = new Size(119, 31);
            bipsButton1.TabIndex = 40;
            bipsButton1.Text = "Home";
            bipsButton1.TextColor = Color.Transparent;
            bipsButton1.UseVisualStyleBackColor = false;
            bipsButton1.Click += bipsButton1_Click;
            // 
            // btnGoHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1348, 629);
            ContextMenuStrip = cmsFood;
            Controls.Add(bipsButton1);
            Controls.Add(pbFood2);
            Controls.Add(label9);
            Controls.Add(bipsCicularPictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtProtein);
            Controls.Add(nudFoodCalorie);
            Controls.Add(btnÜrünFotoEkle);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbFood);
            Controls.Add(btn_FoodUpdate);
            Controls.Add(btnFoodAdd);
            Controls.Add(cmbFoodCategory);
            Controls.Add(txtYağ);
            Controls.Add(txtKarbonhidrat);
            Controls.Add(txt_FoodName);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dgw_Food);
            Margin = new Padding(3, 2, 3, 2);
            Name = "btnGoHome";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            Load += AddFoodFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_Food).EndInit();
            cmsFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFoodCalorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)bipsCicularPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFood2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton dss;
        private DataGridView dgw_Food;
        private TextBox txt_FoodName;
        private ContextMenuStrip cmsFood;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private TextBox txtKarbonhidrat;
        private TextBox txtYağ;
        private ComboBox cmbFoodCategory;
        private BipsControlsForms.Controls.BipsButton btnFoodAdd;
        private BipsControlsForms.Controls.BipsButton btn_FoodUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFood;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private BipsControlsForms.Controls.BipsButton btnBack;
        private BipsControlsForms.Controls.BipsButton btnForward;
        private BipsControlsForms.Controls.BipsButton btnÜrünFotoEkle;
        private NumericUpDown nudFoodCalorie;
        private TextBox txtProtein;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private BipsControlsForms.Controls.BipsCicularPictureBox bipsCicularPictureBox1;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFood2;
        private BipsControlsForms.Controls.BipsButton bipsButton1;
    }
}