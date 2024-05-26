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
        }

        private void DisplayAccountData()
        {
            idBox.Text = BankAccount.Id.ToString();
            nameLabel.Text = BankAccount.Name;
            categoryLabel.Text = BankAccount.DepositCategory;
            sumLabel.Text = BankAccount.CurrentSum.ToString("F2");
            dateTimePickerLastOperation.Value = BankAccount.LastOperationDate.Date;
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
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                if (BankAccount.Withdraw(amount))
                {
                    DisplayAccountData();
                }
                else
                {
                    MessageBox.Show("Недостатньо коштів для зняття", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний формат суми", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                BankAccount.Deposit(amount);
                DisplayAccountData();
            }
            else
            {
                MessageBox.Show("Невірний формат суми", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyInterest_Click(object sender, EventArgs e)
        {
            decimal initialSum = BankAccount.CurrentSum;
            BankAccount.ApplyInterest();
            DisplayAccountData();

            decimal interest = BankAccount.CurrentSum - initialSum;
            if (interest > 0)
            {
                string message = $"Нараховано: {interest:F2} " + Environment.NewLine +
                                 $"Початкова сума: {initialSum:F2}." + Environment.NewLine +
                                 $"Категорієя депозиту: {BankAccount.DepositCategory}." + Environment.NewLine +
                                 $"Поточний баланс: {BankAccount.CurrentSum:F2}";

                MessageBox.Show(message, "Нарахування відсотків", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}
