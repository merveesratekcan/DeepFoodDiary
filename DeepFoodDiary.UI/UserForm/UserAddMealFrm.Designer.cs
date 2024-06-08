namespace DeepFoodDiary.UI.CategoryForm
{
    partial class UserAddMealFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddMealFrm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnHam = new PictureBox();
            btnProfil = new BipsControlsForms.Controls.BipsButton();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            plSidebar = new Panel();
            btnAlcoholicBeverages = new Button();
            btnForBreakfast = new Button();
            btnMainFood = new Button();
            btnSalad = new Button();
            btnSnack = new Button();
            btnSpicesAndSauces = new Button();
            btnBakeryProducts = new Button();
            btnSoups = new Button();
            btnBeverages = new Button();
            btnSugarsAndSweets = new Button();
            btnGrains = new Button();
            btnLegumes = new Button();
            btnFishandSeafood = new Button();
            btnMeatProducts = new Button();
            btnDairyProducts = new Button();
            btnFruits = new Button();
            panel4 = new Panel();
            btnVegetable = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            txtSearchFood = new TextBox();
            dgwCategory = new DataGridView();
            nudPortion = new NumericUpDown();
            lblPortion = new Label();
            btnSaveMealUser = new BipsControlsForms.Controls.BipsButton();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox10 = new PictureBox();
            btnDelete = new BipsControlsForms.Controls.BipsButton();
            dgw_AddedMeal = new DataGridView();
            cmbMeal = new ComboBox();
            dgwBreakfast = new DataGridView();
            dgwLunch = new DataGridView();
            dgwDinner = new DataGridView();
            dgwSnack = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            plSidebar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPortion).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwBreakfast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwLunch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwDinner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwSnack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Controls.Add(btnProfil);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1506, 60);
            panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group_2;
            pictureBox1.Location = new Point(61, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 83, 73);
            label1.Location = new Point(105, 21);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 55;
            label1.Text = "Categories";
            // 
            // btnHam
            // 
            btnHam.BackColor = Color.Gray;
            btnHam.Image = Properties.Resources.add1;
            btnHam.Location = new Point(12, 12);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(34, 37);
            btnHam.SizeMode = PictureBoxSizeMode.Zoom;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(255, 83, 73);
            btnProfil.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnProfil.BorderColor = Color.Aqua;
            btnProfil.BorderRadius = 28;
            btnProfil.BorderSize = 0;
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1362, 12);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(123, 32);
            btnProfil.TabIndex = 31;
            btnProfil.Text = "Profil";
            btnProfil.TextColor = Color.White;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // plSidebar
            // 
            plSidebar.BackColor = Color.White;
            plSidebar.Controls.Add(btnAlcoholicBeverages);
            plSidebar.Controls.Add(btnForBreakfast);
            plSidebar.Controls.Add(btnMainFood);
            plSidebar.Controls.Add(btnSalad);
            plSidebar.Controls.Add(btnSnack);
            plSidebar.Controls.Add(btnSpicesAndSauces);
            plSidebar.Controls.Add(btnBakeryProducts);
            plSidebar.Controls.Add(btnSoups);
            plSidebar.Controls.Add(btnBeverages);
            plSidebar.Controls.Add(btnSugarsAndSweets);
            plSidebar.Controls.Add(btnGrains);
            plSidebar.Controls.Add(btnLegumes);
            plSidebar.Controls.Add(btnFishandSeafood);
            plSidebar.Controls.Add(btnMeatProducts);
            plSidebar.Controls.Add(btnDairyProducts);
            plSidebar.Controls.Add(btnFruits);
            plSidebar.Controls.Add(panel4);
            plSidebar.Controls.Add(flowLayoutPanel1);
            plSidebar.Dock = DockStyle.Left;
            plSidebar.Location = new Point(0, 60);
            plSidebar.Name = "plSidebar";
            plSidebar.Size = new Size(207, 553);
            plSidebar.TabIndex = 36;
            // 
            // btnAlcoholicBeverages
            // 
            btnAlcoholicBeverages.BackColor = Color.FromArgb(224, 224, 224);
            btnAlcoholicBeverages.Location = new Point(8, 481);
            btnAlcoholicBeverages.Name = "btnAlcoholicBeverages";
            btnAlcoholicBeverages.Size = new Size(196, 22);
            btnAlcoholicBeverages.TabIndex = 54;
            btnAlcoholicBeverages.Text = "Alcoholic Beverages";
            btnAlcoholicBeverages.UseVisualStyleBackColor = false;
            btnAlcoholicBeverages.Click += btnAlcoholicBeverages_Click;
            // 
            // btnForBreakfast
            // 
            btnForBreakfast.BackColor = Color.FromArgb(224, 224, 224);
            btnForBreakfast.Location = new Point(8, 453);
            btnForBreakfast.Name = "btnForBreakfast";
            btnForBreakfast.Size = new Size(196, 22);
            btnForBreakfast.TabIndex = 53;
            btnForBreakfast.Text = "For Breakfast";
            btnForBreakfast.UseVisualStyleBackColor = false;
            btnForBreakfast.Click += btnForBreakfast_Click;
            // 
            // btnMainFood
            // 
            btnMainFood.BackColor = Color.FromArgb(224, 224, 224);
            btnMainFood.Location = new Point(8, 425);
            btnMainFood.Name = "btnMainFood";
            btnMainFood.Size = new Size(196, 22);
            btnMainFood.TabIndex = 52;
            btnMainFood.Text = "Main Food";
            btnMainFood.UseVisualStyleBackColor = false;
            btnMainFood.Click += btnMainFood_Click;
            // 
            // btnSalad
            // 
            btnSalad.BackColor = Color.FromArgb(224, 224, 224);
            btnSalad.Location = new Point(8, 397);
            btnSalad.Name = "btnSalad";
            btnSalad.Size = new Size(196, 22);
            btnSalad.TabIndex = 51;
            btnSalad.Text = "Salad";
            btnSalad.UseVisualStyleBackColor = false;
            btnSalad.Click += btnSalad_Click;
            // 
            // btnSnack
            // 
            btnSnack.BackColor = Color.FromArgb(224, 224, 224);
            btnSnack.Location = new Point(8, 369);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(196, 22);
            btnSnack.TabIndex = 50;
            btnSnack.Text = "Snack";
            btnSnack.UseVisualStyleBackColor = false;
            btnSnack.Click += btnSnack_Click;
            // 
            // btnSpicesAndSauces
            // 
            btnSpicesAndSauces.BackColor = Color.FromArgb(224, 224, 224);
            btnSpicesAndSauces.Location = new Point(8, 341);
            btnSpicesAndSauces.Name = "btnSpicesAndSauces";
            btnSpicesAndSauces.Size = new Size(196, 22);
            btnSpicesAndSauces.TabIndex = 49;
            btnSpicesAndSauces.Text = "Spices And Sauces";
            btnSpicesAndSauces.UseVisualStyleBackColor = false;
            btnSpicesAndSauces.Click += btnSpicesAndSauces_Click;
            // 
            // btnBakeryProducts
            // 
            btnBakeryProducts.BackColor = Color.FromArgb(224, 224, 224);
            btnBakeryProducts.Location = new Point(8, 313);
            btnBakeryProducts.Name = "btnBakeryProducts";
            btnBakeryProducts.Size = new Size(196, 22);
            btnBakeryProducts.TabIndex = 48;
            btnBakeryProducts.Text = "Bakery Products";
            btnBakeryProducts.UseVisualStyleBackColor = false;
            btnBakeryProducts.Click += btnBakeryProducts_Click;
            // 
            // btnSoups
            // 
            btnSoups.BackColor = Color.FromArgb(224, 224, 224);
            btnSoups.Location = new Point(8, 285);
            btnSoups.Name = "btnSoups";
            btnSoups.Size = new Size(196, 22);
            btnSoups.TabIndex = 47;
            btnSoups.Text = "Soups ";
            btnSoups.UseVisualStyleBackColor = false;
            btnSoups.Click += btnSoups_Click;
            // 
            // btnBeverages
            // 
            btnBeverages.BackColor = Color.FromArgb(224, 224, 224);
            btnBeverages.Location = new Point(8, 257);
            btnBeverages.Name = "btnBeverages";
            btnBeverages.Size = new Size(196, 22);
            btnBeverages.TabIndex = 46;
            btnBeverages.Text = "Beverages";
            btnBeverages.UseVisualStyleBackColor = false;
            btnBeverages.Click += btnBeverages_Click;
            // 
            // btnSugarsAndSweets
            // 
            btnSugarsAndSweets.BackColor = Color.FromArgb(224, 224, 224);
            btnSugarsAndSweets.Location = new Point(8, 229);
            btnSugarsAndSweets.Name = "btnSugarsAndSweets";
            btnSugarsAndSweets.Size = new Size(196, 22);
            btnSugarsAndSweets.TabIndex = 45;
            btnSugarsAndSweets.Text = "Sugars And Sweets";
            btnSugarsAndSweets.UseVisualStyleBackColor = false;
            btnSugarsAndSweets.Click += btnSugarsAndSweets_Click;
            // 
            // btnGrains
            // 
            btnGrains.BackColor = Color.FromArgb(224, 224, 224);
            btnGrains.Location = new Point(8, 201);
            btnGrains.Name = "btnGrains";
            btnGrains.Size = new Size(196, 22);
            btnGrains.TabIndex = 44;
            btnGrains.Text = "Grains";
            btnGrains.UseVisualStyleBackColor = false;
            btnGrains.Click += btnGrains_Click;
            // 
            // btnLegumes
            // 
            btnLegumes.BackColor = Color.FromArgb(224, 224, 224);
            btnLegumes.Location = new Point(8, 173);
            btnLegumes.Name = "btnLegumes";
            btnLegumes.Size = new Size(196, 22);
            btnLegumes.TabIndex = 43;
            btnLegumes.Text = "Legumes";
            btnLegumes.UseVisualStyleBackColor = false;
            btnLegumes.Click += btnLegumes_Click;
            // 
            // btnFishandSeafood
            // 
            btnFishandSeafood.BackColor = Color.FromArgb(224, 224, 224);
            btnFishandSeafood.Location = new Point(8, 145);
            btnFishandSeafood.Name = "btnFishandSeafood";
            btnFishandSeafood.Size = new Size(196, 22);
            btnFishandSeafood.TabIndex = 42;
            btnFishandSeafood.Text = "Fishand Seafood";
            btnFishandSeafood.UseVisualStyleBackColor = false;
            btnFishandSeafood.Click += btnFishandSeafood_Click;
            // 
            // btnMeatProducts
            // 
            btnMeatProducts.BackColor = Color.FromArgb(224, 224, 224);
            btnMeatProducts.Location = new Point(8, 117);
            btnMeatProducts.Name = "btnMeatProducts";
            btnMeatProducts.Size = new Size(196, 22);
            btnMeatProducts.TabIndex = 41;
            btnMeatProducts.Text = "Meat Products";
            btnMeatProducts.UseVisualStyleBackColor = false;
            btnMeatProducts.Click += btnMeatProducts_Click;
            // 
            // btnDairyProducts
            // 
            btnDairyProducts.BackColor = Color.FromArgb(224, 224, 224);
            btnDairyProducts.Location = new Point(8, 89);
            btnDairyProducts.Name = "btnDairyProducts";
            btnDairyProducts.Size = new Size(196, 22);
            btnDairyProducts.TabIndex = 40;
            btnDairyProducts.Text = "Dairy Products";
            btnDairyProducts.UseVisualStyleBackColor = false;
            btnDairyProducts.Click += btnDairyProducts_Click;
            // 
            // btnFruits
            // 
            btnFruits.BackColor = Color.FromArgb(224, 224, 224);
            btnFruits.Location = new Point(8, 61);
            btnFruits.Name = "btnFruits";
            btnFruits.Size = new Size(196, 22);
            btnFruits.TabIndex = 39;
            btnFruits.Text = "Fruits";
            btnFruits.UseVisualStyleBackColor = false;
            btnFruits.Click += btnFruits_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnVegetable);
            panel4.Location = new Point(12, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 21);
            panel4.TabIndex = 39;
            // 
            // btnVegetable
            // 
            btnVegetable.BackColor = Color.FromArgb(224, 224, 224);
            btnVegetable.Location = new Point(-4, 0);
            btnVegetable.Name = "btnVegetable";
            btnVegetable.Size = new Size(196, 21);
            btnVegetable.TabIndex = 38;
            btnVegetable.Text = "Vegetable";
            btnVegetable.UseVisualStyleBackColor = false;
            btnVegetable.Click += btnVegetable_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(199, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(576, 493);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(244, 84);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(304, 81);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(174, 23);
            txtSearchFood.TabIndex = 62;
            txtSearchFood.TextChanged += txtSearchFood_TextChanged;
            // 
            // dgwCategory
            // 
            dgwCategory.BackgroundColor = Color.White;
            dgwCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCategory.Location = new Point(213, 107);
            dgwCategory.Name = "dgwCategory";
            dgwCategory.RowHeadersWidth = 51;
            dgwCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwCategory.Size = new Size(575, 506);
            dgwCategory.TabIndex = 63;
            // 
            // nudPortion
            // 
            nudPortion.Location = new Point(585, 81);
            nudPortion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPortion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPortion.Name = "nudPortion";
            nudPortion.Size = new Size(170, 23);
            nudPortion.TabIndex = 64;
            nudPortion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblPortion
            // 
            lblPortion.AutoSize = true;
            lblPortion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPortion.ForeColor = Color.Gray;
            lblPortion.Location = new Point(525, 84);
            lblPortion.Name = "lblPortion";
            lblPortion.Size = new Size(49, 16);
            lblPortion.TabIndex = 65;
            lblPortion.Text = "Portion";
            // 
            // btnSaveMealUser
            // 
            btnSaveMealUser.BackColor = Color.FromArgb(255, 83, 73);
            btnSaveMealUser.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnSaveMealUser.BackgroundImageLayout = ImageLayout.None;
            btnSaveMealUser.BorderColor = Color.Aqua;
            btnSaveMealUser.BorderRadius = 31;
            btnSaveMealUser.BorderSize = 0;
            btnSaveMealUser.FlatAppearance.BorderSize = 0;
            btnSaveMealUser.FlatStyle = FlatStyle.Flat;
            btnSaveMealUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveMealUser.ForeColor = Color.White;
            btnSaveMealUser.Location = new Point(15, 341);
            btnSaveMealUser.Name = "btnSaveMealUser";
            btnSaveMealUser.Size = new Size(156, 35);
            btnSaveMealUser.TabIndex = 56;
            btnSaveMealUser.Text = "Save Meal";
            btnSaveMealUser.TextColor = Color.White;
            btnSaveMealUser.UseVisualStyleBackColor = false;
            btnSaveMealUser.Click += btnSaveMealUser_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 83, 73);
            label3.Location = new Point(15, 268);
            label3.Name = "label3";
            label3.Size = new Size(66, 29);
            label3.TabIndex = 59;
            label3.Text = "Meal";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(dgw_AddedMeal);
            panel3.Controls.Add(cmbMeal);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnSaveMealUser);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1148, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 553);
            panel3.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Ellipse_19;
            pictureBox8.Location = new Point(302, 248);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(311, 377);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 98;
            pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(0, 438);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(311, 377);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 99;
            pictureBox10.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 83, 73);
            btnDelete.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.BorderColor = Color.Aqua;
            btnDelete.BorderRadius = 31;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(15, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 35);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete Meal";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgw_AddedMeal
            // 
            dgw_AddedMeal.BackgroundColor = Color.White;
            dgw_AddedMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_AddedMeal.Location = new Point(15, 6);
            dgw_AddedMeal.MultiSelect = false;
            dgw_AddedMeal.Name = "dgw_AddedMeal";
            dgw_AddedMeal.ReadOnly = true;
            dgw_AddedMeal.RowHeadersWidth = 51;
            dgw_AddedMeal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_AddedMeal.Size = new Size(332, 236);
            dgw_AddedMeal.TabIndex = 66;
            // 
            // cmbMeal
            // 
            cmbMeal.FormattingEnabled = true;
            cmbMeal.Location = new Point(15, 299);
            cmbMeal.Name = "cmbMeal";
            cmbMeal.Size = new Size(222, 23);
            cmbMeal.TabIndex = 62;
            // 
            // dgwBreakfast
            // 
            dgwBreakfast.BackgroundColor = Color.White;
            dgwBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBreakfast.Location = new Point(793, 107);
            dgwBreakfast.Name = "dgwBreakfast";
            dgwBreakfast.RowHeadersWidth = 51;
            dgwBreakfast.Size = new Size(350, 120);
            dgwBreakfast.TabIndex = 66;
            // 
            // dgwLunch
            // 
            dgwLunch.BackgroundColor = Color.White;
            dgwLunch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwLunch.Location = new Point(793, 233);
            dgwLunch.Name = "dgwLunch";
            dgwLunch.RowHeadersWidth = 51;
            dgwLunch.Size = new Size(350, 120);
            dgwLunch.TabIndex = 67;
            // 
            // dgwDinner
            // 
            dgwDinner.BackgroundColor = Color.White;
            dgwDinner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDinner.Location = new Point(793, 359);
            dgwDinner.Name = "dgwDinner";
            dgwDinner.RowHeadersWidth = 51;
            dgwDinner.Size = new Size(350, 120);
            dgwDinner.TabIndex = 68;
            // 
            // dgwSnack
            // 
            dgwSnack.BackgroundColor = Color.White;
            dgwSnack.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSnack.Location = new Point(793, 485);
            dgwSnack.Name = "dgwSnack";
            dgwSnack.RowHeadersWidth = 51;
            dgwSnack.Size = new Size(350, 128);
            dgwSnack.TabIndex = 69;
            // 
            // UserAddMealFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 613);
            Controls.Add(dgwSnack);
            Controls.Add(dgwDinner);
            Controls.Add(dgwLunch);
            Controls.Add(dgwBreakfast);
            Controls.Add(lblPortion);
            Controls.Add(nudPortion);
            Controls.Add(dgwCategory);
            Controls.Add(txtSearchFood);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(plSidebar);
            Controls.Add(panel1);
            Name = "UserAddMealFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            plSidebar.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPortion).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_AddedMeal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwBreakfast).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwLunch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwDinner).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwSnack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private BipsControlsForms.Controls.BipsButton btnHome;
        private PictureBox pictureBox4;
        private BipsControlsForms.Controls.BipsButton btnProfil;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel plSidebar;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Button btnVegetable;
        private Button btnSugarsAndSweets;
        private Button btnGrains;
        private Button btnLegumes;
        private Button btnFishandSeafood;
        private Button btnMeatProducts;
        private Button btnDairyProducts;
        private Button btnFruits;
        private Button btnAlcoholicBeverages;
        private Button btnForBreakfast;
        private Button btnMainFood;
        private Button btnSalad;
        private Button btnSnack;
        private Button btnSpicesAndSauces;
        private Button btnBakeryProducts;
        private Button btnSoups;
        private Button btnBeverages;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private PictureBox btnHam;
        private Label label2;
        private TextBox txtSearchFood;
        private PictureBox pictureBox1;
        private NumericUpDown nudPortion;
        private Label lblPortion;
        private DataGridView dgwCategory;
        private BipsControlsForms.Controls.BipsButton btnSaveMealUser;
        private Label label3;
        private Panel panel3;
        private ComboBox cmbMeal;
        private DataGridView dgw_AddedMeal;
        private BipsControlsForms.Controls.BipsButton btnDelete;
        private DataGridView dgwBreakfast;
        private DataGridView dgwLunch;
        private DataGridView dgwDinner;
        private DataGridView dgwSnack;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
    }
}