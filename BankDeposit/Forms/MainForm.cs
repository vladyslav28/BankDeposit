using BankDeposit.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankDeposit.Forms
{
    public partial class MainForm : Form
    {
        Bank bank = new Bank();
        const string PATH_TO_DATA = ".\\bank.txt";

        public MainForm()
        {
            InitializeComponent();
            dateTimePickerLastOperation.Value = DateTime.Now.Date;
            dateTimePickerLastOperation.MaxDate = DateTime.Now.Date;
            dateTimePickerBirth.MaxDate = DateTime.Now.Date;
            dateTimePickerBirth.Value = DateTime.Now.Date;
            InitializeCategoryBox();
            LoadBankData();
            InitializeErrorLabels();

            
        }

        private void LoadBankData()
        {
            bank = Bank.LoadData(PATH_TO_DATA);
            bankAccountBindingSource.DataSource = bank.BankAccounts;
            UpdateLabelCount();
        }

        private void UpdateLabelCount()
        {
            labelCount.Text = $"Кількість елементів: {resultList.Items.Count}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви хочете зберегти зміни перед виходом?", "Зберегти зміни", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               
                bank.SaveData(PATH_TO_DATA);
            }
            else if (result == DialogResult.No)
            {
                
            }
            else if (result == DialogResult.Cancel)
            {
              
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBankData();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank.SaveData(PATH_TO_DATA);
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
            InitializeErrorLabels();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(false);
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(false);
        }

        private void sumBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(false);
        }

        private void InitializeErrorLabels()
        {
            errorIdLabel.Visible = false;
            errorInfoIdLabel.Visible = false;

            errorNameLabel.Visible = false;
            errorInfoNameLabel.Visible = false;

            errorSumLabel.Visible = false;
            erorrInfoSumLabel.Visible = false;
        }

        private bool ValidateInput(bool showErrorMessages)
        {
            bool isValid = true;

            if (!string.IsNullOrEmpty(idBox.Text) && !int.TryParse(idBox.Text, out _))
            {
                errorIdLabel.Visible = true;
                if (showErrorMessages)
                {
                    errorInfoIdLabel.Text = "ID містить заборонені символи";
                    errorInfoIdLabel.Visible = true;
                }
                isValid = false;
            }
            else
            {
                errorIdLabel.Visible = false;
                errorInfoIdLabel.Visible = false;
            }

            if (nameBox.Text.Any(c => !char.IsLetter(c) && c != '.'))
            {
                errorNameLabel.Visible = true;
                if (showErrorMessages)
                {
                    errorInfoNameLabel.Text = "";
                    if (nameBox.Text.Any(char.IsDigit))
                    {
                        errorInfoNameLabel.Text += "ПІБ містить заборонені символи";
                    }
                    if (nameBox.Text.Any(c => !char.IsLetter(c) && c != '.' && !char.IsDigit(c)))
                    {
                        errorInfoNameLabel.Text += "ПІБ містить заборонені символи";
                    }
                    errorInfoNameLabel.Visible = true;
                }
                isValid = false;
            }
            else
            {
                errorNameLabel.Visible = false;
                errorInfoNameLabel.Visible = false;
            }

            if (!string.IsNullOrEmpty(sumBox.Text))
            {
                if (!decimal.TryParse(sumBox.Text, out _) || sumBox.Text.Any(c => !char.IsDigit(c) && c != ','))
                {
                    errorSumLabel.Visible = true;
                    if (showErrorMessages)
                    {
                        erorrInfoSumLabel.Text = "Сума містить заборонені символи";
                        erorrInfoSumLabel.Visible = true;
                    }
                    isValid = false;
                }
                else
                {
                    errorSumLabel.Visible = false;
                    erorrInfoSumLabel.Visible = false;
                }
            }
            else
            {
                errorSumLabel.Visible = false;
                erorrInfoSumLabel.Visible = false;
            }

            if (!isValid && showErrorMessages)
            {
                MessageBox.Show("Будь ласка, виправте помилки введення", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateInput(true);
            if (!isValid)
            {
                return;
            }

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
            }

            var result = bank.SearchAccounts(idBox.Text, nameBox.Text, depositCategory, birthDate, lastOperationDate, currentSum);
            bankAccountBindingSource.DataSource = result;
            UpdateLabelCount();

            MessageBox.Show(resultList.Items.Count.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddBankAccount();
        }

        private void додатиЕлементToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBankAccount();
        }

        private void AddBankAccount()
        {
            int newId = bank.BankAccounts.Any() ? bank.BankAccounts.Max(a => a.Id) + 1 : 1;
            var addForm = new BankAccountAddForm(newId, bank);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                BankAccount newAccount = addForm.BankAccount;
                bank.AddAccount(newAccount);
                buttonSearch_Click(null!, null!);
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
                    if (moneyOperationForm.IsChanged())
                    {
                        MessageBox.Show("Зміни збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    buttonSearch_Click(null!, null!);
                }
            }
            else
            {
                MessageBox.Show("Акаунт не обрано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void фінансовіОпераціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bank.BankAccounts.Any())
            {
                BankAccount bankAccount = bank.BankAccounts.First();
                var moneyOperationForm = new MoneyOperationForm(bankAccount, bank);

                if (moneyOperationForm.ShowDialog() == DialogResult.OK)
                {
                    if (moneyOperationForm.IsChanged())
                    {
                        MessageBox.Show("Зміни збережено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    buttonSearch_Click(null!, null!);
                }
            }
            else
            {
                MessageBox.Show("Акаунти відсутні", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItem is BankAccount bankAccount)
            {
                DeleteBankAccount(bankAccount);
            }
            else
            {
                MessageBox.Show("Акаунт не обрано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть ID акаунту для видалення:", "Видалити акаунт", "");
            if (int.TryParse(input, out int accountId))
            {
                BankAccount? selectedAccount = bank.BankAccounts.FirstOrDefault(a => a.Id == accountId);
                if (selectedAccount != null)
                {
                    DeleteBankAccount(selectedAccount);
                }
                else
                {
                    MessageBox.Show("Акаунт з цим ID не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний формат ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBankAccount(BankAccount bankAccount)
        {
            string message = $"Ви впевнені, що хочете видалити цей акаунт?" + Environment.NewLine + Environment.NewLine +
                             $"ID: {bankAccount.Id}" + Environment.NewLine +
                             $"ПІБ: {bankAccount.Name}" + Environment.NewLine +
                             $"Дата народження: {bankAccount.BirthDate:dd.MM.yyyy}" + Environment.NewLine +
                             $"Категорія депозиту: {bankAccount.DepositCategory}" + Environment.NewLine +
                             $"Поточна сума: {bankAccount.CurrentSum}" + Environment.NewLine +
                             $"Дата останьої операції: {bankAccount.LastOperationDate:dd.MM.yyyy}" + Environment.NewLine;

            DialogResult result = MessageBox.Show(message, "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = bank.DeleteAccount(bankAccount.Id);
                if (isDeleted)
                {
                    buttonSearch_Click(null!, null!);
                    MessageBox.Show("Акаунт видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                BankAccount selectedAccount = (resultList.SelectedItem as BankAccount)!;
                if (selectedAccount != null)
                {
                    EditBankAccount(selectedAccount);
                }
            }
            else
            {
                MessageBox.Show("Акаунт не обрано", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть ID акаунту для редагування:", "Редагувати акаунт", "");
            if (int.TryParse(input, out int accountId))
            {
                BankAccount? selectedAccount = bank.BankAccounts.FirstOrDefault(a => a.Id == accountId);
                if (selectedAccount != null)
                {
                    EditBankAccount(selectedAccount);
                }
                else
                {
                    MessageBox.Show("Акаунт з цим ID не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний формат ID", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBankAccount(BankAccount selectedAccount)
        {
            var bankAccountEditForm = new BankAccountEditForm(selectedAccount);
            if (bankAccountEditForm.ShowDialog() == DialogResult.OK)
            {
                if (bankAccountEditForm.IsChanged())
                {
                    DialogResult confirmResult = MessageBox.Show(
                        "Ви впевнені, що хочете зберегти зміни?",
                        "Підтвердження збереження",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Інформацію змінено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buttonSearch_Click(null!, null!);
                    }
                    else
                    {
                        bankAccountEditForm.CancelOperation();
                        EditBankAccount(selectedAccount);
                    }
                }
            }
        }

        private void helpWithTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Поля ПІБ Можуть мати значення:літери,точка(.)" + Environment.NewLine +
                "Поля Id можуть мати лише числові значення" + Environment.NewLine +
                "Поля Суми можуть мати лише числові значення,роздільником є кома (,)" + Environment.NewLine +
                "Категорія визначається за датою народження,якщо клієнтові менше 18 років(відносно сьогоднішньої дати),то категорія її депозиту Junior(12%),якщо більше 18 - Standart(15%)";

            MessageBox.Show(message, "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Програма створена для керування інформацією вкладників банку" + Environment.NewLine +
                "Додатковими функціями програми є можливість проводити фінансові операції такі як:" + Environment.NewLine +
                "зняття коштів,поповнення рахунку,нарахування відсотків за певною категорією депозиту" + Environment.NewLine + Environment.NewLine +
                "Програма розроблена: ст.гр ПЗПІ-23-6 Ус Владиславом";

            MessageBox.Show(message, "Підказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
