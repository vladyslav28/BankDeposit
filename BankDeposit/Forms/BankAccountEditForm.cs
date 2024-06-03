using BankDeposit.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankDeposit.Forms
{
    public partial class BankAccountEditForm : Form
    {
        private BankAccount bankAccount;
        private readonly BankAccount originalBankAccount;
        private readonly Bank bank = new();

        public BankAccountEditForm(BankAccount bankAccount)
        {
            InitializeComponent();
            InitializeCategoryBox();

            dateTimePickerBirth.Value = DateTime.Now.Date;
            dateTimePickerBirth.MaxDate = DateTime.Now.Date;
            dateTimePickerLastOperation.Value = DateTime.Now.Date;
            dateTimePickerLastOperation.MaxDate = DateTime.Now.Date;

            InitializeErrorLabels();
            this.bankAccount = bankAccount;
            PasteData(bankAccount);
            originalBankAccount = new BankAccount
            {
                Id = bankAccount.Id,
                Name = bankAccount.Name,
                BirthDate = bankAccount.BirthDate,
                LastOperationDate = bankAccount.LastOperationDate,
                DepositCategory = bankAccount.DepositCategory,
                CurrentSum = bankAccount.CurrentSum
            };
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
            return nameBox.Text != originalBankAccount.Name ||
                   dateTimePickerBirth.Value.Date != originalBankAccount.BirthDate ||
                   dateTimePickerLastOperation.Value.Date != originalBankAccount.LastOperationDate ||
                   categoryBox.SelectedItem?.ToString() != originalBankAccount.DepositCategory ||
                   sumBox.Text != originalBankAccount.CurrentSum.ToString();
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
            string selectedCategory = categoryBox.SelectedItem?.ToString() ?? string.Empty;

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

            string category = categoryBox.SelectedItem?.ToString() ?? string.Empty;
            if (isNameValid && isSumValid && isCategoryValid)
            {
                if (IsChanged())
                {
                    DialogResult confirmResult = MessageBox.Show(
                        "Ви впевнені, що хочете зберегти зміни?",
                        "Підтвердження збереження",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        bankAccount = bank.UpdateAccount(bankAccount, nameBox.Text, dateTimePickerBirth.Value.Date, dateTimePickerLastOperation.Value.Date, category, sumBox.Text);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else if (confirmResult == DialogResult.No)
                    {
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                    }
                }
                else
                {
                    bankAccount = bank.UpdateAccount(bankAccount, nameBox.Text, dateTimePickerBirth.Value.Date, dateTimePickerLastOperation.Value.Date, category, sumBox.Text);
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
            bankAccount = bank.CancelAccount(bankAccount, originalBankAccount);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
