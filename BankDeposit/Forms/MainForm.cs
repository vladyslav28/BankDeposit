using BankDeposit.Models;
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
    public partial class MainForm : Form
    {
        Bank bank = new Bank();
        public MainForm()
        {

            InitializeComponent();
            InitializeCategoryBox();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
            categoryBox.SelectedIndex = -1;
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string depositCategory = categoryBox.SelectedItem?.ToString();

            DateTime? birthDate = dateTimePickerBirth.Checked ? dateTimePickerBirth.Value : null;
            DateTime? lastOperationDate = dateTimePickerLastOperation.Checked ? dateTimePickerLastOperation.Value.Date : null;

            decimal? currentSum = null;
            if (!string.IsNullOrEmpty(sumBox.Text))
            {
                if (decimal.TryParse(sumBox.Text, out decimal parsedSum))
                {
                    currentSum = parsedSum;
                }
                else
                {
                    //Зробити видачу помилки (красні мітки)
                    return;
                }
            }

            var result = bank.SearchAccounts(idBox.Text, nameBox.Text, depositCategory, birthDate, lastOperationDate, currentSum);
            bankAccountBindingSource.DataSource = result;


            MessageBox.Show(dateTimePickerBirth.Value.ToString());
            //MessageBox.Show(result.Value.ToString());

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            var dialog = new BankAccountEditForm(bank.Accounts[0]);
            dialog.Show();
        }
    }
}


//         (string id, string name, string depositCategory , DateTime birthDate,
//         decimal currentSum, DateTime lastOperationDate)
