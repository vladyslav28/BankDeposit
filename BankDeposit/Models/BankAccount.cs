using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        
        public string CustomDisplay
        {
            get { return $"   {LastOperationDate} ///{BirthDate} "; }
        }

        public BankAccount() { }
    }
}
// зробити другий ліст в якому буде виводитись инфа про обраного клієнта. Після звязку
// Зробити схожий вивід з поясннеям Name:""
