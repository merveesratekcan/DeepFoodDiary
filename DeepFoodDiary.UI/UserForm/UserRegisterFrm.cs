using AutoMapper;
using ComponentFactory.Krypton.Toolkit;
using DeepFoodDiary.BLL.Interfaces.IService;
using DeepFoodDiary.BLL.Services;
using DeepFoodDiary.ENTITY.Entities;
using DeepFoodDiary.UI.MainForm;
using DeepFoodDiary.UI.Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepFoodDiary.UI.UserForm
{
    public partial class UserRegisterFrm : KryptonForm
    {
        private readonly IUserService _userService;
        private readonly IUserDetailService _userDetailService;
        private readonly IMapper _mapper;
        public UserRegisterFrm()
        {
            InitializeComponent();
            var config = new MapperConfiguration(
               cfg =>
               {
                   cfg.AddProfile<ModelProfiler>();
               });
            _mapper = config.CreateMapper();
            _userDetailService = new UserDetailService();
            _userService = new UserService();
        }
        private void RegisterClear()
        {
            txtRgsUsername.Text = string.Empty;
            txtRgsPassword.Text = string.Empty;
            txtSecuritycode.Text = string.Empty;

            txtFullname.Text = string.Empty;
            txtHeight.Text = string.Empty;
            txtWeight.Text = string.Empty;
            dtpBirthday.Text = string.Empty;

        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (pictureboxUser != null && pictureboxUser.Image != null)
            {

                MemoryStream stream = new MemoryStream();
                pictureboxUser.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                if (stream.Length == 0)
                {
                    MessageBox.Show("Please upload a picture.");
                    return;
                }
                string email = txtRgsUsername.Text;
                string password = txtRgsPassword.Text;
                string securityCode = txtSecuritycode.Text;


                if (_userService.RegisterControl(email))
                {
                    MessageBox.Show("There is a member for this email!");
                    return;
                }
                if (!PasswordCriteria(password))
                {

                    return;
                }
                // TextBox'tan email adresini alınacak

                if (IsValidEmail(email))
                {
                    // Email adresi geçerli ise burada işlemler yapılır
                    MessageBox.Show("Email address is valid.");
                }
                else
                {
                    // Email adresi geçerli değilse kullanıcıya uyarı verilir
                    MessageBox.Show("Please enter a valid email address.");
                }

                User user = new User()
                {
                    UserName = email,
                    Password = _userService.HashPassword(password),
                    SecurityCode = securityCode,
                    UserPicture = stream.ToArray()
                }; _userService.Add(user);


                int age = DateTime.Now.Year - dtpBirthday.Value.Year;
                int height = int.Parse(txtHeight.Text);
                int weight = int.Parse(txtWeight.Text);
                bool gender = cbFemale.Checked ? true : false;
                UserDetails userDetails = new UserDetails()
                {
                    UserId = user.Id,
                    FullName = txtFullname.Text,
                    Gender = cbFemale.Checked ? true : false,
                    BirthDate = dtpBirthday.Value,
                    Height = int.Parse(txtHeight.Text),
                    Weight = int.Parse(txtWeight.Text),
                    TotalCalorie = (float)(_userDetailService.DailyCaloriesNeed(age, height, weight, gender))
                }; _userDetailService.Add(userDetails);
                MessageBox.Show("Register successfully");
            }

            else
            {
                MessageBox.Show("PictureBox or image is not initialized.");
            }
            UserLoginFrm userLoginFrm = new UserLoginFrm();
            userLoginFrm.Show();
            this.Hide();
        }
        private bool PasswordCriteria(string password)
        {
            bool isValid = true;
            string errorMessage = "Şifre kriterlerine uymuyor! Lütfen aşağıdaki kriterleri sağlayın:\n\n";

            // En az 8 karakter uzunluğunda olmalıdır
            if (password.Length < 8)
            {
                errorMessage += "- En az 8 karakter uzunluğunda olmalıdır.\n";
                isValid = false;
            }

            // En az 2 büyük harf içermelidir
            if (password.Count(char.IsUpper) < 2)
            {
                errorMessage += "- En az 2 büyük harf içermelidir.\n";
                isValid = false;
            }

            // En az 3 küçük harf içermelidir
            if (password.Count(char.IsLower) < 3)
            {
                errorMessage += "- En az 3 küçük harf içermelidir.\n";
                isValid = false;
            }

            // Özel karakterlerden en az 2 tanesini içermelidir
            var specialCharCount = password.Count(c => "!:+*".Contains(c));
            if (specialCharCount < 2)
            {
                errorMessage += "- En az 2 özel karakter içermelidir.\n";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;

        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFemale.Checked == true)
            {
                cbMale.Checked = false;

            }

        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMale.Checked == true)
            {
                cbFemale.Checked = false;

            }
        }

        public bool IsValidEmail(string email)
        {
            // Email formatı için kullanılacak regex ifadesi
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Regex.IsMatch metoduyla email formatını kontrol et
            return Regex.IsMatch(email, emailPattern);
        }

        private void UserRegisterFrm_Load_1(object sender, EventArgs e)
        {
            txtSecuritycode.Enabled = false;
            Random random = new Random();
            txtSecuritycode.Text = random.Next(100000, 900000).ToString();
        }

        private void btnAddYourPicture_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.DefaultExt = "jpg";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;
                pictureboxUser.Image = Image.FromFile(path);
                pictureboxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                throw new Exception("Lütfen bir resim seçiniz");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeFrm homeFrm = new HomeFrm();
            homeFrm.Show();
            this.Hide();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void cbFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbFemale.Checked == true)
            {
                cbMale.Checked = false;

            }
        }

        private void cbMale_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbMale.Checked == true)
            {
                cbFemale.Checked = false;

            }
        }

        private void btnuyaripass_Click(object sender, EventArgs e)
        {
            var information = "It does not meet the password criteria! Please meet the following criteria\n" +
                "It must be at least 8 characters long.\n" +
                " It must contain at least 2 capital letters.\n" +
                "Must contain at least 3 lowercase letters\n" +
                "It must contain at least 2 special characters.";
            MessageBox.Show(information, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

   
    }
}
