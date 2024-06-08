namespace DeepFoodDiary.UI.MainForm
{
    partial class UserProfilMainFrm
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
            btnProfil = new BipsControlsForms.Controls.BipsButton();
            bips = new BipsControlsForms.Controls.BipsButton();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnProfil);
            panel1.Controls.Add(bips);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 60);
            panel1.TabIndex = 33;
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
            btnProfil.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1187, 12);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(123, 32);
            btnProfil.TabIndex = 37;
            btnProfil.Text = "Profil";
            btnProfil.TextColor = Color.White;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // bips
            // 
            bips.BackColor = Color.YellowGreen;
            bips.BackGroundColor = Color.YellowGreen;
            bips.BorderColor = Color.Aqua;
            bips.BorderRadius = 28;
            bips.BorderSize = 0;
            bips.FlatAppearance.BorderSize = 0;
            bips.FlatStyle = FlatStyle.Flat;
            bips.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bips.ForeColor = Color.White;
            bips.Location = new Point(950, 12);
            bips.Name = "bips";
            bips.Size = new Size(216, 32);
            bips.TabIndex = 36;
            bips.Text = "Add Meal";
            bips.TextColor = Color.White;
            bips.UseVisualStyleBackColor = false;
            bips.Click += bips_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(87, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagecilek1;
            pictureBox1.Location = new Point(716, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 486);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.text1;
            pictureBox2.Location = new Point(125, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(585, 350);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(125, 90);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 36;
            label1.Text = "WELCOME";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Sweet;
            pictureBox3.Location = new Point(326, 85);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 37;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.f;
            pictureBox5.Location = new Point(359, 85);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(42, 42);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.m;
            pictureBox6.Location = new Point(285, 85);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // UserProfilMainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "UserProfilMainFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private BipsControlsForms.Controls.BipsButton bips;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private BipsControlsForms.Controls.BipsButton btnProfil;
    }
}