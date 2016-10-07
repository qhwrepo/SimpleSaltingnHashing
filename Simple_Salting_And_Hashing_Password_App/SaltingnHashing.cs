/*
    This is a simple winform application that allows you to convert
    your password to salted hashed code with SHA256.

    Note that every time you click the generate button, even though
    you don't change your password, the hashed (with salt) password
    changes.

*/



using System;
using System.Windows.Forms;


namespace Simple_Salting_And_Hashing_Password_App
{
    public partial class SaltingnHashing : Form
    {
        public SaltingnHashing()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxPassword.Text))
            {
                MessageBox.Show("Please enter a valid password!");
            }
            else
            {
                var salt = CreateSalt(10);
                txtBoxSalt.Text = salt;
                txtBoxHashed.Text = GenerateSHA256Hash(txtBoxPassword.Text, salt);
            }
        }

        private String CreateSalt(int Size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[Size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private String GenerateSHA256Hash(string pwd, string salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd + salt);
            var sha256hashstring = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", String.Empty);
        }
    }
}
