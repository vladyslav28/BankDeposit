using BankDeposit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDeposit.Forms
{

    public partial class BankAccountAddForm : Form
    {
        public BankAccount BankAccount { get; private set; }
        private Bank bank;

        public BankAccountAddForm(int newId, Bank bank)
        {
            InitializeComponent();
            InitializeCategoryBox();

            this.bank = bank;
            BankAccount = new BankAccount { Id = newId };
            idBox.Text = newId.ToString(); 
        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
        }

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = dateTimePickerBirth.Value.Date;
            string depositCategory = bank.GetDepositCategory(dateTimePickerBirth.Value.Date);

            if (depositCategory == "Junior(12%)")
            {
                categoryBox.SelectedIndex = 0;
            }
            else if (depositCategory == "Standart(15%)")
            {
                categoryBox.SelectedIndex = 1;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BankAccount.Name = nameBox.Text;
            BankAccount.BirthDate = dateTimePickerBirth.Value.Date;
            BankAccount.LastOperationDate = dateTimePickerLastOperation.Value.Date;
            BankAccount.DepositCategory = categoryBox.SelectedItem?.ToString() ?? string.Empty;
            if (decimal.TryParse(sumBox.Text, out decimal parsedSum))
            {
                BankAccount.CurrentSum = Math.Round(parsedSum, 2);
            }
            else
            {
                MessageBox.Show("Невірний формат суми", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }








    }
}
