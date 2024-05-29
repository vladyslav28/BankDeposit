using BankDeposit.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankDeposit.Forms
{
    public partial class BankAccountEditForm : Form
    {
        private BankAccount bankAccount;
        private BankAccount originalBankAccount;
        private Bank bank = new Bank();

        public BankAccountEditForm(BankAccount bankAccount)
        {
            InitializeComponent();
            InitializeCategoryBox();

            dateTimePickerBirth.Value = DateTime.Now.Date;
            dateTimePickerBirth.MaxDate = DateTime.Now.Date;
            dateTimePickerLastOperation.Value = DateTime.Now.Date;
            dateTimePickerLastOperation.MaxDate = DateTime.Now.Date;

            InitializeErrorLabels();
            PasteData(bankAccount);
        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
        }

        private void InitializeErrorLabels()
        {
            labelErrorName.Visible = false;
            labelInfoName.Visible = false;

            labelErrorSum.Visible = false;
            labelInfoSum.Visible = false;

            labelErrorCategory.Visible = false;
            labelInfoCategory.Visible = false;
        }

        public void PasteData(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
            originalBankAccount = new BankAccount
            {
                Id = bankAccount.Id,
                Name = bankAccount.Name,
                BirthDate = bankAccount.BirthDate,
                LastOperationDate = bankAccount.LastOperationDate,
                DepositCategory = bankAccount.DepositCategory,
                CurrentSum = bankAccount.CurrentSum
            };

            idBox.Text = bankAccount.Id.ToString();
            nameBox.Text = bankAccount.Name;
            sumBox.Text = bankAccount.CurrentSum.ToString();
            dateTimePickerBirth.Value = bankAccount.BirthDate;
            dateTimePickerLastOperation.Value = bankAccount.LastOperationDate;

            if (bankAccount.DepositCategory == "Junior(12%)")
            {
                if (categoryBox.Items.Count > 0)
                    categoryBox.SelectedIndex = 0;
            }
            else if (bankAccount.DepositCategory == "Standart(15%)")
            {
                if (categoryBox.Items.Count > 1)
                    categoryBox.SelectedIndex = 1;
            }
        }

        public bool IsChanged()
        {
            return bankAccount.Name != originalBankAccount.Name ||
                   bankAccount.Id != originalBankAccount.Id ||
                   bankAccount.BirthDate != originalBankAccount.BirthDate ||
                   bankAccount.LastOperationDate != originalBankAccount.LastOperationDate ||
                   bankAccount.DepositCategory != originalBankAccount.DepositCategory ||
                   bankAccount.CurrentSum != originalBankAccount.CurrentSum;
        }

        private bool ValidateName(bool showErrorMessages)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(nameBox.Text))
            {
                if (showErrorMessages)
                {
                    labelErrorName.Visible = true;
                    labelInfoName.Text = "ПІБ не може бути порожнім";
                    labelInfoName.Visible = true;
                }
                else
                {
                    labelErrorName.Visible = false;
                    labelInfoName.Visible = false;
                }
                isValid = false;
            }
            else if (nameBox.Text.Any(c => !char.IsLetter(c) && c != '.' && c != ' '))
            {
                labelErrorName.Visible = true;
                if (showErrorMessages)
                {
                    labelInfoName.Text = "ПІБ містить заборонені символи";
                    labelInfoName.Visible = true;
                }
                isValid = false;
            }
            else
            {
                labelErrorName.Visible = false;
                labelInfoName.Visible = false;
            }

            return isValid;
        }

        private bool ValidateSum(bool showErrorMessages)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(sumBox.Text))
            {
                if (showErrorMessages)
                {
                    labelErrorSum.Visible = true;
                    labelInfoSum.Text = "Сума не може бути порожньою";
                    labelInfoSum.Visible = true;
                }
                else
                {
                    labelErrorSum.Visible = false;
                    labelInfoSum.Visible = false;
                }
                isValid = false;
            }
            else if (!decimal.TryParse(sumBox.Text, out _) || sumBox.Text.Any(c => !char.IsDigit(c) && c != ','))
            {
                labelErrorSum.Visible = true;
                if (showErrorMessages)
                {
                    labelInfoSum.Text = "Сума містить заборонені символи";
                    labelInfoSum.Visible = true;
                }
                isValid = false;
            }
            else
            {
                labelErrorSum.Visible = false;
                labelInfoSum.Visible = false;
            }

            return isValid;
        }

        private bool ValidateCategory(bool showErrorMessages)
        {
            bool isValid = true;
            string expectedCategory = bank.GetDepositCategory(dateTimePickerBirth.Value.Date);
            string selectedCategory = categoryBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedCategory))
            {
                if (showErrorMessages)
                {
                    labelErrorCategory.Visible = true;
                    labelInfoCategory.Text = "Категорія не обрана";
                    labelInfoCategory.Visible = true;
                }
                else
                {
                    labelErrorCategory.Visible = false;
                    labelInfoCategory.Visible = false;
                }
                isValid = false;
            }
            else if (selectedCategory != expectedCategory)
            {
                labelErrorCategory.Visible = true;
                if (showErrorMessages)
                {
                    labelInfoCategory.Text = "Категорія не відповідає даті народження";
                    labelInfoCategory.Visible = true;
                }
                isValid = false;
            }
            else
            {
                labelErrorCategory.Visible = false;
                labelInfoCategory.Visible = false;
            }

            return isValid;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            labelInfoName.Visible = false;
            ValidateName(false);
        }

        private void sumBox_TextChanged(object sender, EventArgs e)
        {
            labelInfoSum.Visible = false;
            ValidateSum(false);
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelInfoCategory.Visible = false;
            ValidateCategory(false);
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = dateTimePickerBirth.Value.Date;
            string depositCategory = bank.GetDepositCategory(dateTimePickerBirth.Value.Date);

            if (depositCategory == "Junior(12%)")
            {
                if (categoryBox.Items.Count > 0)
                    categoryBox.SelectedIndex = 0;
            }
            else if (depositCategory == "Standart(15%)")
            {
                if (categoryBox.Items.Count > 1)
                    categoryBox.SelectedIndex = 1;
            }
        }

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isNameValid = ValidateName(true);
            bool isSumValid = ValidateSum(true);
            bool isCategoryValid = ValidateCategory(true);

            if (isNameValid && isSumValid && isCategoryValid)
            {
                bankAccount.Name = nameBox.Text;
                bankAccount.BirthDate = dateTimePickerBirth.Value.Date;
                bankAccount.LastOperationDate = dateTimePickerLastOperation.Value.Date;
                bankAccount.DepositCategory = categoryBox.SelectedItem?.ToString();
                if (decimal.TryParse(sumBox.Text, out decimal parsedSum))
                {
                    bankAccount.CurrentSum = Math.Round(parsedSum, 2);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виправте помилки введення", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelOperation()
        {
            bankAccount.Id = originalBankAccount.Id;
            bankAccount.Name = originalBankAccount.Name;
            bankAccount.BirthDate = originalBankAccount.BirthDate;
            bankAccount.LastOperationDate = originalBankAccount.LastOperationDate;
            bankAccount.DepositCategory = originalBankAccount.DepositCategory;
            bankAccount.CurrentSum = originalBankAccount.CurrentSum;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
