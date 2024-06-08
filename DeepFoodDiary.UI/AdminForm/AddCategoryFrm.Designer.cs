namespace DeepFoodDiary.UI
{
    partial class AddCategoryFrm
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
            cmsCategory = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            dgw_Category = new DataGridView();
            txt_CategoryName = new TextBox();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            btnCategoryAdd = new BipsControlsForms.Controls.BipsButton();
            btn_CategoryUpdate = new BipsControlsForms.Controls.BipsButton();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnForward = new BipsControlsForms.Controls.BipsButton();
            pbFood = new BipsControlsForms.Controls.BipsCicularPictureBox();
            label2 = new Label();
            BtnBack = new BipsControlsForms.Controls.BipsButton();
            cmsCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Category).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            SuspendLayout();
            // 
            // cmsCategory
            // 
            cmsCategory.ImageScalingSize = new Size(20, 20);
            cmsCategory.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
            cmsCategory.Name = "contextMenuStrip1";
            cmsCategory.Size = new Size(121, 48);
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
            // dgw_Category
            // 
            dgw_Category.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Category.Location = new Point(584, 111);
            dgw_Category.Margin = new Padding(3, 2, 3, 2);
            dgw_Category.MultiSelect = false;
            dgw_Category.Name = "dgw_Category";
            dgw_Category.ReadOnly = true;
            dgw_Category.RowHeadersWidth = 51;
            dgw_Category.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_Category.Size = new Size(576, 403);
            dgw_Category.TabIndex = 7;
            // 
            // txt_CategoryName
            // 
            txt_CategoryName.BackColor = Color.FromArgb(224, 224, 224);
            txt_CategoryName.Location = new Point(231, 249);
            txt_CategoryName.Margin = new Padding(3, 2, 3, 2);
            txt_CategoryName.Multiline = true;
            txt_CategoryName.Name = "txt_CategoryName";
            txt_CategoryName.Size = new Size(283, 34);
            txt_CategoryName.TabIndex = 5;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnCategoryAdd.BackGroundColor = Color.FromArgb(64, 64, 64);
            btnCategoryAdd.BorderColor = Color.Aqua;
            btnCategoryAdd.BorderRadius = 40;
            btnCategoryAdd.BorderSize = 0;
            btnCategoryAdd.FlatAppearance.BorderSize = 0;
            btnCategoryAdd.FlatStyle = FlatStyle.Flat;
            btnCategoryAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategoryAdd.ForeColor = Color.White;
            btnCategoryAdd.Location = new Point(231, 317);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(283, 40);
            btnCategoryAdd.TabIndex = 9;
            btnCategoryAdd.Text = "Add";
            btnCategoryAdd.TextColor = Color.White;
            btnCategoryAdd.UseVisualStyleBackColor = false;
            btnCategoryAdd.Click += btnCategoryAdd_Click_1;
            // 
            // btn_CategoryUpdate
            // 
            btn_CategoryUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btn_CategoryUpdate.BackGroundColor = Color.FromArgb(64, 64, 64);
            btn_CategoryUpdate.BorderColor = Color.Aqua;
            btn_CategoryUpdate.BorderRadius = 40;
            btn_CategoryUpdate.BorderSize = 0;
            btn_CategoryUpdate.FlatAppearance.BorderSize = 0;
            btn_CategoryUpdate.FlatStyle = FlatStyle.Flat;
            btn_CategoryUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CategoryUpdate.ForeColor = Color.White;
            btn_CategoryUpdate.Location = new Point(231, 378);
            btn_CategoryUpdate.Name = "btn_CategoryUpdate";
            btn_CategoryUpdate.Size = new Size(283, 40);
            btn_CategoryUpdate.TabIndex = 10;
            btn_CategoryUpdate.Text = "Update";
            btn_CategoryUpdate.TextColor = Color.White;
            btn_CategoryUpdate.UseVisualStyleBackColor = false;
            btn_CategoryUpdate.Click += btn_CategoryUpdate_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 210);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 12;
            label1.Text = "Add Or Update Category";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Rectangle_75;
            pictureBox1.Location = new Point(186, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            btnForward.Location = new Point(1217, 566);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(119, 31);
            btnForward.TabIndex = 30;
            btnForward.Text = "Next";
            btnForward.TextColor = Color.Transparent;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += bipsButton1_Click;
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
            pbFood.Location = new Point(3, 0);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(63, 62);
            pbFood.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFood.TabIndex = 31;
            pbFood.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.FromArgb(255, 83, 73);
            label2.Location = new Point(72, 18);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 32;
            label2.Text = "Admin Panel";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Silver;
            BtnBack.BackGroundColor = Color.Silver;
            BtnBack.BorderColor = Color.Aqua;
            BtnBack.BorderRadius = 31;
            BtnBack.BorderSize = 0;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.Transparent;
            BtnBack.Location = new Point(3, 566);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(119, 31);
            BtnBack.TabIndex = 33;
            BtnBack.Text = "Back";
            BtnBack.TextColor = Color.Transparent;
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // AddCategoryFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            ContextMenuStrip = cmsCategory;
            Controls.Add(BtnBack);
            Controls.Add(label2);
            Controls.Add(pbFood);
            Controls.Add(btnForward);
            Controls.Add(label1);
            Controls.Add(btn_CategoryUpdate);
            Controls.Add(btnCategoryAdd);
            Controls.Add(txt_CategoryName);
            Controls.Add(pictureBox1);
            Controls.Add(dgw_Category);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddCategoryFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            cmsCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgw_Category).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip cmsCategory;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private DataGridView dgw_Category;
        private TextBox txt_CategoryName;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private BipsControlsForms.Controls.BipsButton btnCategoryAdd;
        private BipsControlsForms.Controls.BipsButton btn_CategoryUpdate;
        private Label label1;
        private PictureBox pictureBox1;
        private BipsControlsForms.Controls.BipsButton btnForward;
        private BipsControlsForms.Controls.BipsCicularPictureBox pbFood;
        private Label label2;
        private BipsControlsForms.Controls.BipsButton BtnBack;
    }
}