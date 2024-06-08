namespace DeepFoodDiary.UI.UserForm
{
    partial class ForgetPasswordFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPasswordFrm));
            kryptonPaletteForgetPass = new ComponentFactory.Krypton.Toolkit.KryptonPalette(components);
            btnUpdatePassword = new BipsControlsForms.Controls.BipsButton();
            txtNewPass = new TextBox();
            txtNewPassEmail = new TextBox();
            label1 = new Label();
            txtNewPassCode = new TextBox();
            label5 = new Label();
            label2 = new Label();
            lblCreateNewPass = new Label();
            pictureBox1 = new PictureBox();
            txtReturnNewPass = new TextBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            btnLogin = new BipsControlsForms.Controls.BipsButton();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // kryptonPaletteForgetPass
            // 
            kryptonPaletteForgetPass.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = Color.FromArgb(255, 83, 73);
            btnUpdatePassword.BackGroundColor = Color.FromArgb(255, 83, 73);
            btnUpdatePassword.BorderColor = Color.Aqua;
            btnUpdatePassword.BorderRadius = 28;
            btnUpdatePassword.BorderSize = 0;
            btnUpdatePassword.FlatAppearance.BorderSize = 0;
            btnUpdatePassword.FlatStyle = FlatStyle.Flat;
            btnUpdatePassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdatePassword.ForeColor = Color.White;
            btnUpdatePassword.Location = new Point(285, 463);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(268, 39);
            btnUpdatePassword.TabIndex = 54;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.TextColor = Color.White;
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // txtNewPass
            // 
            txtNewPass.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPass.Location = new Point(288, 337);
            txtNewPass.Multiline = true;
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(268, 25);
            txtNewPass.TabIndex = 65;
            // 
            // txtNewPassEmail
            // 
            txtNewPassEmail.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPassEmail.Location = new Point(288, 202);
            txtNewPassEmail.Multiline = true;
            txtNewPassEmail.Name = "txtNewPassEmail";
            txtNewPassEmail.Size = new Size(268, 25);
            txtNewPassEmail.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(288, 249);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 61;
            label1.Text = "Security Code*";
            // 
            // txtNewPassCode
            // 
            txtNewPassCode.BackColor = Color.FromArgb(224, 224, 224);
            txtNewPassCode.Location = new Point(288, 267);
            txtNewPassCode.Multiline = true;
            txtNewPassCode.Name = "txtNewPassCode";
            txtNewPassCode.PasswordChar = '*';
            txtNewPassCode.Size = new Size(268, 25);
            txtNewPassCode.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(288, 319);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 59;
            label5.Text = "New Password*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(288, 184);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 58;
            label2.Text = "Email*";
            // 
            // lblCreateNewPass
            // 
            lblCreateNewPass.AutoSize = true;
            lblCreateNewPass.BackColor = Color.White;
            lblCreateNewPass.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateNewPass.Location = new Point(318, 133);
            lblCreateNewPass.Name = "lblCreateNewPass";
            lblCreateNewPass.Size = new Size(196, 24);
            lblCreateNewPass.TabIndex = 57;
            lblCreateNewPass.Text = "Create New Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sign_up_background;
            pictureBox1.Location = new Point(246, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 463);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // txtReturnNewPass
            // 
            txtReturnNewPass.BackColor = Color.FromArgb(224, 224, 224);
            txtReturnNewPass.Location = new Point(288, 398);
            txtReturnNewPass.Multiline = true;
            txtReturnNewPass.Name = "txtReturnNewPass";
            txtReturnNewPass.PasswordChar = '*';
            txtReturnNewPass.Size = new Size(268, 25);
            txtReturnNewPass.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(288, 380);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 67;
            label3.Text = "New Password*";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(62, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
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
            btnLogin.Location = new Point(1182, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 32);
            btnLogin.TabIndex = 35;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 60);
            panel1.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(612, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 463);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 68;
            pictureBox2.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(-183, 205);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(311, 377);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 96;
            pictureBox9.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Ellipse_19;
            pictureBox7.Location = new Point(-91, 86);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(311, 377);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 95;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1214, 133);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(311, 377);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 101;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Ellipse_19;
            pictureBox6.Location = new Point(1138, 259);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(311, 377);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 100;
            pictureBox6.TabStop = false;
            // 
            // ForgetPasswordFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 629);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(txtReturnNewPass);
            Controls.Add(btnUpdatePassword);
            Controls.Add(txtNewPass);
            Controls.Add(txtNewPassEmail);
            Controls.Add(label1);
            Controls.Add(txtNewPassCode);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lblCreateNewPass);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "ForgetPasswordFrm";
            PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteForgetPass;
        private BipsControlsForms.Controls.BipsButton btnUpdatePassword;
        private TextBox txtNewPass;
        private TextBox txtNewPassEmail;
        private Label label1;
        private TextBox txtNewPassCode;
        private Label label5;
        private Label label2;
        private Label lblCreateNewPass;
        private PictureBox pictureBox1;
        private TextBox txtReturnNewPass;
        private Label label3;
        private PictureBox pictureBox4;
        private BipsControlsForms.Controls.BipsButton btnLogin;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox9;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}