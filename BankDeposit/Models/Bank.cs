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
        private static Random random = new Random();
        public List<BankAccount> BankAccounts { get;  set; }
      
        public Bank() {
            BankAccounts = new List<BankAccount>();
           
            //FillTestData(100);
        }

        public void FillTestData(int n)
        {
            BankAccounts.Clear();
            for (int i = 0; i < n; i++)
            {

                DateTime birthDate = GenerateRandomBirthDate();
                string name = GenerateRandomName();
                string depositCategory = GetDepositCategory(birthDate);

                BankAccounts.Add(new BankAccount
                {
                    Id = i + 1,
                    DepositCategory = depositCategory,
                    Name = name,
                    BirthDate = birthDate.Date,
                    CurrentSum = GenerateRandomAmount(),
                    LastOperationDate = DateTime.Today.AddDays(-random.Next(1, 700)).Date
            });
            }
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

        private string GenerateRandomName()
        {
            string[] maleSurnames =
            {
                 "Іванов", "Петров", "Сидоров", "Коваленко", "Гончаренко", "Шевченко", "Данилюк", "Федорчук", "Захарченко",
                 "Герасименко", "Тарасенко", "Руденко", "Сидоренко", "Савченко", "Волошин", "Матвієнко", "Марченко",
                 "Бондаренко", "Кравченко", "Ткаченко", "Мельник", "Поліщук", "Литвин", "Клименко", "Мазур", "Стеценко",
                 "Дорошенко", "Лук’яненко", "Кулинич", "Гордієнко", "Борисенко", "Кучменко", "Соколов", "Кривенко",
                 "Терещенко", "Білославський", "Бабенко", "Красніков", "Білоусенко", "Корченко", "Мельниченко", "Пархоменко",
                 "Попович", "Мороз", "Шаповаленко", "Терещук", "Поляков", "Бондарчук", "Калашник", "Сагайдак", "Долгоруков"
            };

            string[] femaleSurnames =
            {
                 "Данилюк", "Федорчук", "Захарченко", "Герасименко", "Тарасенко", "Іванова", "Петрова", "Сидорова",
                 "Коваленко", "Гончаренко", "Шевченко", "Бондаренко", "Кравченко", "Ткаченко", "Мельник", "Поліщук",
                 "Литвин", "Руденко", "Сидоренко", "Савченко", "Волошина", "Матвієнко", "Марченко", "Клименко", "Мазур",
                 "Стеценко", "Дорошенко", "Лук’яненко", "Кулинич", "Гордієнко", "Борисенко", "Кучменко", "Соколова",
                 "Кривенко", "Терещенко", "Білославська", "Бабенко", "Краснікова", "Білоусенко", "Корченко", "Мельниченко",
                 "Пархоменко", "Поповича", "Мороз", "Шаповаленко", "Терещук", "Полякова", "Бондарчук", "Калашник",
                 "Сагайдак", "Долгорукова", "Гавриленко", "Маркова", "Міщенко", "Сімоненко", "Мартиненко", "Шевчук",
                 "Шевченко", "Сорокіна", "Козлова"
             };

            string[] initials = { "А", "Б", "В", "Г", "Д", "Е", "Є", "З", "І", "К", "Л", "М", "Н", "О", "П",
                "Р", "С", "Т", "У", "Я" };

            bool isMale = random.Next(2) == 0;
            string surname = isMale ? maleSurnames[random.Next(maleSurnames.Length)] : femaleSurnames[random.Next(femaleSurnames.Length)];
            string midName = initials[random.Next(initials.Length)];
            string name = initials[random.Next(initials.Length)];

            return $"{surname} {name}.{midName}.";
        }

        private DateTime GenerateRandomBirthDate()
        {
            int year = random.Next(DateTime.Now.Year - 90, DateTime.Now.Year - 14);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day,0,0,0);
        }

        private decimal GenerateRandomAmount()
        {
            decimal generatedAmount = Math.Round((decimal)(random.Next(10000, 100000100) / 100.0), 2);
            return generatedAmount;
        }
       
        public List<BankAccount> SearchAccounts(string id, string name, string depositCategory, DateTime? birthDate, DateTime? lastOperationDate, decimal? currentSum)
        {
            var result = new List<BankAccount>();

            foreach (var account in BankAccounts)
            {
                if ((string.IsNullOrEmpty(id) || account.Id.ToString().Contains(id)) &&
                    (string.IsNullOrEmpty(depositCategory) || account.DepositCategory.Contains(depositCategory)) &&
                    (string.IsNullOrEmpty(name) || account.Name.Contains(name)) &&
                    (!birthDate.HasValue || account.BirthDate.Date == birthDate.Value.Date) &&
                    (!lastOperationDate.HasValue || account.LastOperationDate.Date == lastOperationDate.Value.Date) &&
                    (!currentSum.HasValue || account.CurrentSum.ToString().Contains(currentSum.Value.ToString() )))
                {
                    result.Add(account);
                }
            }
            return result;
        }

        public bool DeleteAccount(int accountId)
        {
            BankAccount account = null;
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


        public void SaveData(string path)
        {
            var jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(path, jsonString);
        }

        public static Bank LoadData(string path)
        {
            var jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Bank>(jsonString);
        }


        public void AddAccount(BankAccount newAccount)
        {
            if (BankAccounts.Any(a => a.Id == newAccount.Id)) 
            { 
            //
            }
               

            BankAccounts.Add(newAccount);
        }










    }




}
