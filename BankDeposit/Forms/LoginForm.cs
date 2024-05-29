using System;
using System.Windows.Forms;

namespace BankDeposit.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxUsername.Text = "Admin";
            
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (username == "Admin" && password == "1")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                labelError.Text = "Неправильний пароль";
                labelError.Visible = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
