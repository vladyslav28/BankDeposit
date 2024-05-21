using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
