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
    public partial class BankAccountEditForm : Form
    {
        private BankAccount bankAccount;
        Bank bank = new Bank(); 

        public BankAccountEditForm(BankAccount bankAccount)
        {
            InitializeComponent();
            InitializeCategoryBox();

            this.bankAccount = bankAccount;
            idBox.Text = bankAccount.Id.ToString();
            nameBox.Text = bankAccount.Name;
            if (bankAccount.DepositCategory == "Junior(12%)")
            {
                categoryBox.SelectedIndex = 0;
            }
            else if (bankAccount.DepositCategory == "Standart(15%)")
            {
                categoryBox.SelectedIndex = 1;
            }
            sumBox.Text = bankAccount.CurrentSum.ToString();
            dateTimePickerBirth.Value = bankAccount.BirthDate;
            dateTimePickerLastOperation.Value = bankAccount.LastOperationDate;
        }

        private void buttonEditOk_Click(object sender, EventArgs e)
        {
            bankAccount.Name = nameBox.Text;
            bankAccount.BirthDate = dateTimePickerBirth.Value.Date;
            bankAccount.LastOperationDate = dateTimePickerLastOperation.Value.Date;
            bankAccount.DepositCategory = categoryBox.SelectedItem?.ToString() ?? string.Empty;

            //decimal? currentSum = null;
            //if (!string.IsNullOrEmpty(sumBox.Text))
            //{
            //    if (decimal.TryParse(sumBox.Text, out decimal parsedSum))
            //    {
            //        currentSum = parsedSum;
            //    }
            //    else
            //    {
            //        return;
            //    }
            //}
            bankAccount.CurrentSum = decimal.Parse(sumBox.Text); // Exeption
        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
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

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }






    }








}




