using BankDeposit.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BankDeposit.Forms
{
    public partial class MoneyOperationForm : Form
    {
        public BankAccount BankAccount { get; private set; }
        private BankAccount originalBankAccount;
        private Bank bank;

        public MoneyOperationForm(BankAccount account, Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
            BankAccount = account;
            originalBankAccount = new BankAccount(account);
            DisplayAccountData();
            InitializeErrorLabels();


        }

        private void DisplayAccountData()
        {
            idBox.Text = BankAccount.Id.ToString();
            nameLabel.Text = BankAccount.Name;
            categoryLabel.Text = BankAccount.DepositCategory;
            sumLabel.Text = BankAccount.CurrentSum.ToString() + " ₴";
            dateTimePickerLastOperation.Value = BankAccount.LastOperationDate.Date;
            textBoxAmount.Text = "";
        }

        private void InitializeErrorLabels()
        {
            errorSumLabel.Visible = false;
            errorInfoAmountLabel.Visible = false;
        }

        private bool ValidateInput(bool showErrorMessages)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(textBoxAmount.Text))
            {
                if (showErrorMessages)
                {
                    errorSumLabel.Visible = true;
                    errorInfoAmountLabel.Text = "Сума не може бути порожньою";
                    errorInfoAmountLabel.Visible = true;
                }
                else
                {
                    errorSumLabel.Visible = false;
                    errorInfoAmountLabel.Visible = false;
                }
                isValid = false;
            }
            else if (!decimal.TryParse(textBoxAmount.Text, out _) || textBoxAmount.Text.Any(c => !char.IsDigit(c) && c != ','))
            {
                errorSumLabel.Visible = true;
                if (showErrorMessages)
                {
                    errorInfoAmountLabel.Text = "Сума містить заборонені символи";
                    errorInfoAmountLabel.Visible = true;
                }
                isValid = false;
            }
            else
            {
                errorSumLabel.Visible = false;
                errorInfoAmountLabel.Visible = false;
            }

            if (!isValid && showErrorMessages)
            {
                MessageBox.Show("Будь ласка, виправте помилки введення", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
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
                    CancelOperation();
                    BankAccount = account;
                    originalBankAccount = new BankAccount(account);
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

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            if (ValidateInput(true) && decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                var (success, interest) = BankAccount.Withdraw(amount);
                if (success)
                {
                    DisplayAccountData();
                    DisplayInterestMessage(interest);
                }
                else
                {
                    MessageBox.Show("Недостатньо коштів для зняття", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (ValidateInput(true) && decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                decimal interest = BankAccount.Deposit(amount);
                DisplayAccountData();
                DisplayInterestMessage(interest);
            }
        }

        private void DisplayInterestMessage(decimal interest)
        {
            if (interest > 0)
            {
                string message = $"Нараховано: {interest:F2} " + Environment.NewLine +
                                 $"Початкова сума: {originalBankAccount.CurrentSum:F2}." + Environment.NewLine +
                                 $"Категорія депозиту: {BankAccount.DepositCategory}." + Environment.NewLine +
                                 $"Поточний баланс: {BankAccount.CurrentSum:F2}";

                MessageBox.Show(message, "Нарахування відсотків", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void applyInterest_Click(object sender, EventArgs e)
        {
            decimal interest = BankAccount.ApplyInterest();
            if (interest > 0)
            {
                DisplayAccountData();
                DisplayInterestMessage(interest);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public bool IsChanged()
        {
            return BankAccount.Name != originalBankAccount.Name ||
                   BankAccount.BirthDate != originalBankAccount.BirthDate ||
                   BankAccount.DepositCategory != originalBankAccount.DepositCategory ||
                   BankAccount.CurrentSum != originalBankAccount.CurrentSum ||
                   BankAccount.LastOperationDate != originalBankAccount.LastOperationDate;
        }

        private void CancelOperation()
        {
            BankAccount.Id = originalBankAccount.Id;
            BankAccount.Name = originalBankAccount.Name;
            BankAccount.BirthDate = originalBankAccount.BirthDate;
            BankAccount.DepositCategory = originalBankAccount.DepositCategory;
            BankAccount.CurrentSum = originalBankAccount.CurrentSum;
            BankAccount.LastOperationDate = originalBankAccount.LastOperationDate;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelOperation();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            ValidateInput(false);
        }

        private void MoneyOperationForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    this.DialogResult = DialogResult.OK;
                }
                else if (confirmResult == DialogResult.No)
                {
                    CancelOperation();
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


    }
}