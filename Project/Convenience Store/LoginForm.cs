using Service.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Convenience_Store
{
    public partial class LoginForm : Form
    {
        public LoginForm() { InitializeComponent(); }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("You will be re-direct to the Merchandise manager.", "Login successfully", MessageBoxButtons.OK);

                MerchandiseOrder mainForm = new MerchandiseOrder();
                this.Hide();
                mainForm.Show();
                return;

            } else { MessageBox.Show("Please try again.", "Login failed", MessageBoxButtons.OK); }
        }

        private void cbPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar) { txtPassword.UseSystemPasswordChar = false; }
            else { txtPassword.UseSystemPasswordChar = true; }
        }
    }
}
