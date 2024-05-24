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
        BankAccount bankAccount = new BankAccount();
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

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = dateTimePickerBirth.Value.Date;
        }

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bankAccount.Name = nameBox.Text;
            bankAccount.BirthDate = dateTimePickerBirth.Value.Date;
            bankAccount.LastOperationDate = dateTimePickerLastOperation.Value.Date;
            string depositCategory = GetDepositCategory(dateTimePickerBirth.Value.Date);
           
            if (depositCategory == "Junior(12%)")
            {
                categoryBox.SelectedIndex = 0;
            }
            else if (depositCategory == "Standart(15%)")
            {
                categoryBox.SelectedIndex = 1;
            }

            bankAccount.DepositCategory = categoryBox.SelectedItem?.ToString() ?? string.Empty;

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
            bankAccount.CurrentSum = currentSum ?? 0;

            //
            


        }

        private string GetDepositCategory(DateTime birthDate)
        {
            DateTime today = DateTime.Now.Date;
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age >= 18 ? "Standart(15%)" : "Junior(12%)";
        }
    }
}
