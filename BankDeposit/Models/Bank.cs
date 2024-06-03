using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BankDeposit.Models
{
    public class Bank
    {
        public List<BankAccount> BankAccounts { get; set; }
        public Bank()
        {
            BankAccounts = new List<BankAccount>();
        }

        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }

        public static Bank LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Bank>(jsonString) ?? new Bank();
        }

        public List<BankAccount> SearchAccounts(string id, string name, string depositCategory, DateTime? birthDate, DateTime? lastOperationDate, decimal? currentSum)
        {
            var result = new List<BankAccount>();

            foreach (var account in BankAccounts)
            {
                if ((string.IsNullOrEmpty(id) || account.Id.ToString().Contains(id.Trim())) &&
                    (account.DepositCategory == null || account.DepositCategory.Contains(depositCategory)) &&
                    (string.IsNullOrEmpty(name) || (account.Name != null && account.Name.ToLower().Contains(name.ToLower().Trim()))) &&
                    (!birthDate.HasValue || account.BirthDate.Date == birthDate.Value.Date) &&
                    (!lastOperationDate.HasValue || account.LastOperationDate.Date == lastOperationDate.Value.Date) &&
                    (!currentSum.HasValue || account.CurrentSum.ToString().Contains(currentSum.Value.ToString().Trim())))
                {
                    result.Add(account);
                }
            }
            return result;
        }
       
        public bool DeleteAccount(int accountId)
        {
            BankAccount? account = null;
            foreach (var a in BankAccounts)
            {
                if (a.Id == accountId)
                {
                    account = a;
                    break;
                }
            }

            if (account != null)
            {
                BankAccounts.Remove(account);
                return true;
            }
            return false;
        }

        public void AddAccount(BankAccount newAccount)
        {
            BankAccounts.Add(newAccount);
        }

        public BankAccount? SearchAccountById(int accountId)
        {
            return BankAccounts.FirstOrDefault(a => a.Id == accountId);
        }

        public (bool success, decimal interest) Withdraw(int accountId, decimal amount)
        {
            var account = BankAccounts.FirstOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                return account.Withdraw(amount);
            }
            return (false, 0);
        }

        public decimal Deposit(int accountId, decimal amount)
        {
            var account = BankAccounts.FirstOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                return account.Deposit(amount);
            }
            return 0;
        }

        public decimal ApplyInterest(int accountId)
        {
            var account = BankAccounts.FirstOrDefault(a => a.Id == accountId);
            if (account != null)
            {
                return account.ApplyInterest();
            }
            return 0;
        }

        public string GetDepositCategory(DateTime birthDate)
        {
            DateTime today = DateTime.Now.Date;
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age >= 18 ? "Standart(15%)" : "Junior(12%)";
        }

        public BankAccount UpdateAccount(BankAccount bankAccount, string name, DateTime birthDate, DateTime lastOperationDate, string depositCategory, string currentSum)
        {
            bankAccount.Name = name;
            bankAccount.BirthDate = birthDate;
            bankAccount.LastOperationDate = lastOperationDate;
            bankAccount.DepositCategory = depositCategory;
            if (decimal.TryParse(currentSum, out decimal parsedSum))
            {
                bankAccount.CurrentSum = Math.Round(parsedSum, 2);
            }
            return bankAccount;
        }

        public BankAccount CancelAccount(BankAccount bankAccount, BankAccount originalBankAccount)
        {
            bankAccount.Id = originalBankAccount.Id;
            bankAccount.Name = originalBankAccount.Name;
            bankAccount.BirthDate = originalBankAccount.BirthDate;
            bankAccount.LastOperationDate = originalBankAccount.LastOperationDate;
            bankAccount.DepositCategory = originalBankAccount.DepositCategory;
            bankAccount.CurrentSum = originalBankAccount.CurrentSum;
            return bankAccount;
        }

    }
}














