using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Неправильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}