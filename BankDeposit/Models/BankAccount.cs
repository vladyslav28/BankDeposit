﻿using System;

namespace BankDeposit.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string DepositCategory { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal CurrentSum { get; set; }
        public DateTime LastOperationDate { get; set; }

        public BankAccount() { }

        public BankAccount(BankAccount account)
        {
            Id = account.Id;
            DepositCategory = account.DepositCategory;
            Name = account.Name;
            BirthDate = account.BirthDate;
            CurrentSum = account.CurrentSum;
            LastOperationDate = account.LastOperationDate;
        }

        public string CustomDisplay
        {
            get { return $" {Name} "; }
        }

        public string CustomDisplay1
        {
            get
            {
                return
                    $"ID:{Id} " + Environment.NewLine +
                    $"ПІБ:{Name} " + Environment.NewLine +
                    $"Дата народження:{BirthDate.ToString("dd.MM.yyyy")}" + Environment.NewLine +
                    $"Категорія депозиту:{DepositCategory} " + Environment.NewLine +
                    $"Поточна сума:{CurrentSum} " + Environment.NewLine +
                    $"Дата останьої операції:{LastOperationDate.ToString("dd.MM.yyyy")}" + Environment.NewLine;
            }
        }

        public void ApplyInterest()
        {
            decimal interestRate = DepositCategory == "Junior(12%)" ? 12 : 15;
            int daysPassed = (DateTime.Now.Date - LastOperationDate.Date).Days;
            decimal interest = CurrentSum * (interestRate / 100) * (daysPassed / 365m);
            if (interest > 0)
            {
                CurrentSum += Math.Round(interest, 2);
                LastOperationDate = DateTime.Now.Date;
            }
        }

        public void Deposit(decimal amount)
        {
            ApplyInterest();
            CurrentSum = Math.Round(CurrentSum + amount, 2);
        }

        public bool Withdraw(decimal amount)
        {
            ApplyInterest();
            if (CurrentSum >= amount)
            {
                CurrentSum = Math.Round(CurrentSum - amount, 2);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
