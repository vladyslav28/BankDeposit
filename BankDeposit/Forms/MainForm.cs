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
            bank = Bank.LoadData(PATH_TO_DATA);

            bankAccountBindingSource.DataSource = bank.BankAccounts;
            UpdateLabelCount();

            
        }

        private void UpdateLabelCount()
        {
            labelCount.Text = $"Кількість елементів: {resultList.Items.Count}";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string depositCategory = categoryBox.SelectedItem?.ToString() ?? string.Empty;
            DateTime? birthDate = dateTimePickerBirth.Checked ? dateTimePickerBirth.Value.Date : null;
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
                    MessageBox.Show("Невірний формат суми", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            var result = bank.SearchAccounts(idBox.Text, nameBox.Text, depositCategory, birthDate, lastOperationDate, currentSum);
            bankAccountBindingSource.DataSource = result;
            UpdateLabelCount();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                BankAccount selectedAccount = resultList.SelectedItem as BankAccount;

                var originalAccount = new BankAccount
                {
                    Id = selectedAccount.Id,
                    Name = selectedAccount.Name,
                    BirthDate = selectedAccount.BirthDate,
                    LastOperationDate = selectedAccount.LastOperationDate,
                    DepositCategory = selectedAccount.DepositCategory,
                    CurrentSum = selectedAccount.CurrentSum
                };

                var bookEditForm = new BankAccountEditForm(selectedAccount);
                if (bookEditForm.ShowDialog() == DialogResult.OK)
                {

                    bool isChanged = selectedAccount.Name != originalAccount.Name ||
                                     selectedAccount.Id != originalAccount.Id ||
                                     selectedAccount.BirthDate != originalAccount.BirthDate ||
                                     selectedAccount.LastOperationDate != originalAccount.LastOperationDate ||
                                     selectedAccount.DepositCategory != originalAccount.DepositCategory ||
                                     selectedAccount.CurrentSum != originalAccount.CurrentSum ;

                    if (isChanged)
                    {
                        MessageBox.Show("Інформацію змінено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonSearch_Click(null, null);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItem is BankAccount bankAccount)
            {
                string message = $"Ви впевнені, що хочете видалити цей акаунт ?" + Environment.NewLine + Environment.NewLine +
                          $"ID: {bankAccount.Id} " + Environment.NewLine +
                          $"ПІБ: {bankAccount.Name} " + Environment.NewLine +
                          $"Дата народження: {bankAccount.BirthDate.ToString("dd.MM.yyyy")}" + Environment.NewLine +
                          $"Категорія депозиту: {bankAccount.DepositCategory} " + Environment.NewLine +
                          $"Поточна сума: {bankAccount.CurrentSum} " + Environment.NewLine +
                          $"Дата останьої операції: {bankAccount.LastOperationDate.ToString("dd.MM.yyyy")}" + Environment.NewLine;

                DialogResult result = MessageBox.Show(message, "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = bank.DeleteAccount(bankAccount.Id);
                    if (isDeleted)
                    {
                        buttonSearch_Click(null, null);
                        MessageBox.Show("Акаунт видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Акаунт не обрано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int newId = bank.BankAccounts.Any() ? bank.BankAccounts.Max(a => a.Id) + 1 : 1;
            var addForm = new BankAccountAddForm(newId, bank);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                BankAccount newAccount = addForm.BankAccount;
                bank.AddAccount(newAccount);
                buttonSearch_Click(null, null);
                MessageBox.Show("Акаунт додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItem is BankAccount bankAccount)
            {
                var moneyOperationForm = new MoneyOperationForm(bankAccount, bank);

                if (moneyOperationForm.ShowDialog() == DialogResult.OK)
                {
                    buttonSearch_Click(null, null);
                }
            }
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

        private void dateTimePickerBirth_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBirth.Value = dateTimePickerBirth.Value.Date;
        }

        private void dateTimePickerLastOperation_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerLastOperation.Value = dateTimePickerLastOperation.Value.Date;
        }

        const string PATH_TO_DATA = ".\\bank.txt";

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank = Bank.LoadData(PATH_TO_DATA);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.SaveData(PATH_TO_DATA);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            categoryBox.SelectedIndex = -1;
            dateTimePickerBirth.Value = DateTime.Today.Date;
            dateTimePickerLastOperation.Value = DateTime.Today.Date;
            dateTimePickerBirth.Checked = false;
            dateTimePickerLastOperation.Checked = false;
            idBox.Text = "";
            sumBox.Text = "";
            nameBox.Text = "";
        }

        


    }

}



