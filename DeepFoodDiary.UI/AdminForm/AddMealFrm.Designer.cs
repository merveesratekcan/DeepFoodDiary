namespace DeepFoodDiary.UI
{
    partial class AddMealFrm
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
            txt_MealName = new TextBox();
            cmsMeal = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            dgw_Meal = new DataGridView();
            btnBack = new BipsControlsForms.Controls.BipsButton();
            pictureBox1 = new PictureBox();
            btnAddMeal = new BipsControlsForms.Controls.BipsButton();
            label1 = new Label();
            btnForward = new BipsControlsForms.Controls.BipsButton();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            label2 = new Label();
            pbFood = new BipsControlsForms.Controls.BipsCicularPictureBox();
            btnUpdateMeal = new BipsControlsForms.Controls.BipsButton();
            cmsMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Meal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            SuspendLayout();
            // 
            // txt_MealName
            // 
            txt_MealName.BackColor = Color.Silver;
            txt_MealName.Location = new Point(213, 244);
            txt_MealName.Margin = new Padding(3, 2, 3, 2);
            txt_MealName.Multiline = true;
            txt_MealName.Name = "txt_MealName";
            txt_MealName.Size = new Size(277, 36);
            txt_MealName.TabIndex = 0;
            // 
            // cmsMeal
            // 
            cmsMeal.ImageScalingSize = new Size(20, 20);
            cmsMeal.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
            cmsMeal.Name = "contextMenuStrip1";
            cmsMeal.Size = new Size(121, 48);
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
            // dgw_Meal
            // 
            dgw_Meal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Meal.Location = new Point(578, 97);
            dgw_Meal.Margin = new Padding(3, 2, 3, 2);
            dgw_Meal.MultiSelect = false;
            dgw_Meal.Name = "dgw_Meal";
            dgw_Meal.ReadOnly = true;
            dgw_Meal.RowHeadersWidth = 51;
            dgw_Meal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Meal.Size = new Size(624, 403);
            dgw_Meal.TabIndex = 3;
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
            btnBack.Location = new Point(3, 569);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 31);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.Transparent;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_75;
            pictureBox1.Location = new Point(158, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnAddMeal
            // 
            btnAddMeal.BackColor = Color.FromArgb(64, 64, 64);
            btnAddMeal.BackGroundColor = Color.FromArgb(64, 64, 64);
            btnAddMeal.BorderColor = Color.Aqua;
            btnAddMeal.BorderRadius = 40;
            btnAddMeal.BorderSize = 0;
            btnAddMeal.FlatAppearance.BorderSize = 0;
            btnAddMeal.FlatStyle = FlatStyle.Flat;
            btnAddMeal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMeal.ForeColor = Color.White;
            btnAddMeal.Location = new Point(213, 309);
            btnAddMeal.Name = "btnAddMeal";
            btnAddMeal.Size = new Size(277, 40);
            btnAddMeal.TabIndex = 31;
            btnAddMeal.Text = "Add";
            btnAddMeal.TextColor = Color.White;
            btnAddMeal.UseVisualStyleBackColor = false;
            btnAddMeal.Click += btnAddMeal_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 203);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 33;
            label1.Text = "Add Or Update Meal";
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
            btnForward.Location = new Point(1217, 569);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(119, 31);
            btnForward.TabIndex = 34;
            btnForward.Text = "Next";
            btnForward.TextColor = Color.Transparent;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(255, 83, 73);
            label2.Location = new Point(72, 20);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 36;
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
            pbFood.Location = new Point(3, 2);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(63, 62);
            pbFood.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFood.TabIndex = 35;
            pbFood.TabStop = false;
            // 
            // btnUpdateMeal
            // 
            btnUpdateMeal.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdateMeal.BackGroundColor = Color.FromArgb(64, 64, 64);
            btnUpdateMeal.BorderColor = Color.Aqua;
            btnUpdateMeal.BorderRadius = 40;
            btnUpdateMeal.BorderSize = 0;
            btnUpdateMeal.FlatAppearance.BorderSize = 0;
            btnUpdateMeal.FlatStyle = FlatStyle.Flat;
            btnUpdateMeal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateMeal.ForeColor = Color.White;
            btnUpdateMeal.Location = new Point(213, 376);
            btnUpdateMeal.Name = "btnUpdateMeal";
            btnUpdateMeal.Size = new Size(277, 40);
            btnUpdateMeal.TabIndex = 37;
            btnUpdateMeal.Text = "Update";
            btnUpdateMeal.TextColor = Color.White;
            btnUpdateMeal.UseVisualStyleBackColor = false;
            btnUpdateMeal.Click += btnUpdateMeal_Click;
            // 
            // AddMealFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            ContextMenuStrip = cmsMeal;
            Controls.Add(btnUpdateMeal);
            Controls.Add(label2);
            Controls.Add(pbFood);
            Controls.Add(btnForward);
            Controls.Add(label1);
            Controls.Add(btnAddMeal);
            Controls.Add(txt_MealName);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(dgw_Meal);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddMealFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            cmsMeal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgw_Meal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_MealName;
        private MaterialSkin.Controls.MaterialButton kj;
        private ContextMenuStrip cmsMeal;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private DataGridView dgw_Meal;
        private MaterialSkin.Controls.MaterialButton btn_MealUpdate;
        private BipsControlsForms.Controls.BipsButton btnBack;
        private PictureBox pictureBox1;
        private BipsControlsForms.Controls.BipsButton btnAddMeal;
       
        private Label label1;
        private BipsControlsForms.Controls.BipsButton btnForward;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label label2;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFood;
        private BipsControlsForms.Controls.BipsButton btnUpdateMeal;
    }
}