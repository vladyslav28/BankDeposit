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
    public partial class MoneyOperationForm : Form
    {
        private BankAccount bankAccount;
        private Bank bank;
        public MoneyOperationForm(BankAccount account, Bank bank)
        {
            InitializeComponent();
            bankAccount = account;
            this.bank = bank;
            DisplayAccountData();
        }

        private void DisplayAccountData()
        {
            idBox.Text = bankAccount.Id.ToString();
            nameLabel.Text = bankAccount.Name;
            categoryLabel.Text = bankAccount.DepositCategory;
            sumLabel.Text = bankAccount.CurrentSum.ToString();
            dateTimePickerLastOperation.Value = bankAccount.LastOperationDate.Date;

        }

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

       

        private void buttonIdSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idBox.Text, out int accountId))
            {
                var account = bank.BankAccounts.FirstOrDefault(a => a.Id == accountId);
                if (account != null)
                {
                    bankAccount = account;
                    DisplayAccountData();
                }
                else
                {
                    MessageBox.Show("Акаунта з цим ID не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний формат ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        












    }
}

