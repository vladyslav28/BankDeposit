using BankDeposit.Models;
using System;
using System.Linq;
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

            this.bank = bank; 

            InitializeCategoryBox();

            dateTimePickerBirth.Value = DateTime.Now.Date;
            dateTimePickerBirth.MaxDate = DateTime.Now.Date;
            dateTimePickerLastOperation.Value = DateTime.Now.Date;
            dateTimePickerLastOperation.MaxDate = DateTime.Now.Date;
           
            UpdateCategoryBasedOnBirthDate();
            
            BankAccount = new BankAccount { Id = newId };
            idBox.Text = newId.ToString();

            InitializeErrorLabels();
        }

        private void InitializeCategoryBox()
        {
            categoryBox.Items.Add("Junior(12%)");
            categoryBox.Items.Add("Standart(15%)");
            categoryBox.SelectedIndex = -1;
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

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = dateTimePickerBirth.Value.Date;
            UpdateCategoryBasedOnBirthDate();
        }

        private void UpdateCategoryBasedOnBirthDate()
        {
            if (bank == null) return;

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
            else if (nameBox.Text.Any(c => !char.IsLetter(c) && c != '.'))
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
            if (bank == null) return false; 

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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool isNameValid = ValidateName(true);
            bool isSumValid = ValidateSum(true);
            bool isCategoryValid = ValidateCategory(true);

            if (isNameValid && isSumValid && isCategoryValid)
            {
                var result = MessageBox.Show("Ви дійсно хочете зберегти новий акаунт?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BankAccount.Name = nameBox.Text;
                    BankAccount.BirthDate = dateTimePickerBirth.Value.Date;
                    BankAccount.LastOperationDate = dateTimePickerLastOperation.Value.Date;
                    BankAccount.DepositCategory = categoryBox.SelectedItem?.ToString();
                    if (decimal.TryParse(sumBox.Text, out decimal parsedSum))
                    {
                        BankAccount.CurrentSum = Math.Round(parsedSum, 2);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виправте помилки введення", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
