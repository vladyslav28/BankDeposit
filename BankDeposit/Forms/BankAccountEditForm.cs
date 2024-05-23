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
        readonly BankAccount bankAccount = new BankAccount();
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

            dateTimePickerBirth.Value = bankAccount.BirthDate.Date;
            dateTimePickerBirth.Update();

            MessageBox.Show(bankAccount.BirthDate.ToString());
            MessageBox.Show(dateTimePickerBirth.Value.ToString());

        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
        }

    }
}
