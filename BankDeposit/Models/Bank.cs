using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDeposit.Models
{
    public class Bank
    {
        private static Random random = new Random();
        public List<BankAccount> Accounts { get; set; } 
        public Bank() {
            Accounts = new List<BankAccount>();
          
            FillTestData(100);
        }

        public void FillTestData(int n)
        {
            Accounts.Clear();
            for (int i = 0; i < n; i++)
            {

                DateTime birthDate = GenerateRandomBirthDate();
                string name = GenerateRandomName();
                string depositCategory = GetDepositCategory(birthDate);

                Accounts.Add(new BankAccount
                {
                    Id = i + 1,
                    DepositCategory = depositCategory,
                    Name = name,
                    BirthDate = birthDate,
                    CurrentSum = GenerateRandomAmount(),
                    LastOperationDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0,0).AddDays(-random.Next(1, 700))

                });
            }
        }

        private string GetDepositCategory(DateTime birthDate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthDate.Year;

            if (today < birthDate.AddYears(age))
            {
                age--;
            }

            return age >= 18 ? "Standart(15%)" : "Junior(12%)";
        }

        private string GenerateRandomName()
        {
            string[] maleFirstNames =
            {
            "Іван", "Петро", "Олександр", "Микола", "Василь", "Андрій", "Олег",
            "Ростислав", "Григорій", "Роман", "Ігор", "Віталій", "Леонід",
            "Максим", "Євген", "Степан", "Кирило", "Павло", "Ілля", "Валерій",
            "Юрій", "Владислав", "Дмитро", "Сергій", "Артем", "Володимир", "Богдан"
            };

            string[] femaleFirstNames =
            {
            "Анна", "Олена", "Наталія", "Ірина", "Тетяна", "Світлана", "Ольга",
            "Дарина", "Зоя", "Лариса", "Мирослава", "Оксана", "Тамара",
            "Марія", "Юлія", "Вікторія", "Людмила", "Катерина", "Аліна", "Анастасія",
            "Вероніка", "Зінаїда", "Надія", "Раїса", "Софія", "Єлизавета", "Любов"
            };

            string[] maleLastNames =
            {
            "Іванов", "Петров", "Сидоров", "Коваленко", "Гончаренко", "Шевченко",
            "Данилюк", "Федорчук", "Захарченко", "Герасименко", "Тарасенко",
            "Руденко", "Сидоренко", "Савченко", "Волошин", "Матвієнко", "Марченко",
            "Бондаренко", "Кравченко", "Ткаченко", "Мельник", "Поліщук", "Литвин",
            "Клименко", "Мазур", "Стеценко", "Дорошенко", "Лук’яненко", "Кулинич"
            };

            string[] femaleLastNames =
            {
            "Данилюк", "Федорчук", "Захарченко", "Герасименко", "Тарасенко",
            "Іванова", "Петрова", "Сидорова", "Коваленко", "Гончаренко", "Шевченко",
            "Бондаренко", "Кравченко", "Ткаченко", "Мельник", "Поліщук", "Литвин",
            "Руденко", "Сидоренко", "Савченко", "Волошина", "Матвієнко", "Марченко",
            "Клименко", "Мазур", "Стеценко", "Дорошенко", "Лук’яненко", "Кулинич"
            };

            string[] malePatronymics =
            {
            "Іванович", "Петрович", "Олександрович", "Миколайович", "Васильович",
            "Ростиславович", "Григорович", "Романович", "Ігорович",
            "Віталійович", "Леонідович", "Максимович", "Євгенович", "Степанович",
            "Сергійович", "Артемович", "Володимирович", "Богданович",
            "Андрійович", "Олегович", "Юрійович", "Тарасович", "Дмитрович",
            "Кирилович", "Павлович", "Вадимович", "Валерійович"
            };

            string[] femalePatronymics =
            {
            "Кирилівна", "Павлівна", "Вадимівна", "Валеріївна",
            "Іванівна", "Петрівна", "Олександрівна", "Миколаївна", "Василівна",
            "Ростиславівна", "Григорівна", "Романівна", "Ігорівна",
            "Віталіївна", "Леонідівна", "Максимівна", "Євгенівна", "Степанівна",
            "Андріївна", "Олегівна", "Юріївна", "Тарасівна", "Дмитрівна",
            "Сергіївна", "Артемівна", "Володимирівна", "Богданівна"
            };

            bool isMale = random.Next(2) == 0;
            string firstName = isMale ? maleFirstNames[random.Next(maleFirstNames.Length)] : femaleFirstNames[random.Next(femaleFirstNames.Length)];
            string lastName = isMale ? maleLastNames[random.Next(maleLastNames.Length)] : femaleLastNames[random.Next(femaleLastNames.Length)];
            string patronymic = isMale ? malePatronymics[random.Next(malePatronymics.Length)] : femalePatronymics[random.Next(femalePatronymics.Length)];

            return $"{lastName} {firstName[0]}.{patronymic[0]}.";
        }

        private DateTime GenerateRandomBirthDate()
        {
            int year = random.Next(DateTime.Now.Year - 80, DateTime.Now.Year - 14);
            int month = random.Next(1, 13);
            int day = random.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day);
        }

        private decimal GenerateRandomAmount()
        {
            decimal generatedAmount = Math.Round((decimal)(random.Next(10000, 100000100) / 100.0), 2);
            return generatedAmount;
        }

        public List<BankAccount> SearchAccounts(string id, string name, string depositCategory, DateTime? birthDate, DateTime? lastOperationDate, decimal? currentSum)
        {
            var result = new List<BankAccount>();

            foreach (var account in Accounts)
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



















    }




}
