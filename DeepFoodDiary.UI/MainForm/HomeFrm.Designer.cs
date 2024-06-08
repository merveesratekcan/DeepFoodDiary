namespace DeepFoodDiary.UI.MainForm
{
    partial class HomeFrm
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
            pictureBox5 = new PictureBox();
            btnAdminLogin = new BipsControlsForms.Controls.BipsButton();
            btnLogin = new BipsControlsForms.Controls.BipsButton();
            pictureBox4 = new PictureBox();
            btnSingUp = new BipsControlsForms.Controls.BipsButton();
            btnAboutUs = new BipsControlsForms.Controls.BipsButton();
            kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(btnAdminLogin);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnSingUp);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 60);
            panel1.TabIndex = 33;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Ellipse_20;
            pictureBox5.Location = new Point(1135, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 37;
            pictureBox5.TabStop = false;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.FromArgb(255, 83, 73);
            btnAdminLogin.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnAdminLogin.BorderColor = Color.Aqua;
            btnAdminLogin.BorderRadius = 28;
            btnAdminLogin.BorderSize = 0;
            btnAdminLogin.FlatAppearance.BorderSize = 0;
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(1203, 12);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(123, 32);
            btnAdminLogin.TabIndex = 37;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.TextColor = Color.White;
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 83, 73);
            btnLogin.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnLogin.BorderColor = Color.Aqua;
            btnLogin.BorderRadius = 28;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(987, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 32);
            btnLogin.TabIndex = 36;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
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
            // btnSingUp
            // 
            btnSingUp.BackColor = Color.FromArgb(255, 83, 73);
            btnSingUp.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnSingUp.BorderColor = Color.Aqua;
            btnSingUp.BorderRadius = 28;
            btnSingUp.BorderSize = 0;
            btnSingUp.FlatAppearance.BorderSize = 0;
            btnSingUp.FlatStyle = FlatStyle.Flat;
            btnSingUp.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSingUp.ForeColor = Color.White;
            btnSingUp.Location = new Point(849, 12);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(123, 32);
            btnSingUp.TabIndex = 31;
            btnSingUp.Text = "Sing Up";
            btnSingUp.TextColor = Color.White;
            btnSingUp.UseVisualStyleBackColor = false;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.BackColor = Color.FromArgb(224, 224, 224);
            btnAboutUs.BackGroundColor = Color.FromArgb(224, 224, 224);
            btnAboutUs.BorderColor = Color.Aqua;
            btnAboutUs.BorderRadius = 27;
            btnAboutUs.BorderSize = 0;
            btnAboutUs.FlatAppearance.BorderSize = 0;
            btnAboutUs.FlatStyle = FlatStyle.Flat;
            btnAboutUs.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAboutUs.ForeColor = Color.FromArgb(255, 83, 73);
            btnAboutUs.Location = new Point(266, 482);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(316, 50);
            btnAboutUs.TabIndex = 33;
            btnAboutUs.Text = "About Us";
            btnAboutUs.TextColor = Color.FromArgb(255, 83, 73);
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.text;
            pictureBox1.Location = new Point(150, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imagecilek2;
            pictureBox2.Location = new Point(740, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(457, 474);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Group_2;
            pictureBox3.Location = new Point(217, 482);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 50);
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // HomeFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 629);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnAboutUs);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "HomeFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private BipsControlsForms.Controls.BipsButton btnAboutUs;
        private BipsControlsForms.Controls.BipsButton btnSingUp;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private PictureBox pictureBox1;
        private BipsControlsForms.Controls.BipsButton btnLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private BipsControlsForms.Controls.BipsButton btnAdminLogin;
        private PictureBox pictureBox5;
    }
}