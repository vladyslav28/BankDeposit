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
        public int Id { get; set; } //Value
        public string DepositCategory { get; set; } 
        public string Name { get; set; } 
        public DateTime BirthDate { get; set; } 
        public decimal CurrentSum { get; set; } 
        public DateTime LastOperationDate { get; set; } 

        
        public string CustomDisplay
        {
            get { return $"{Name}  {LastOperationDate.ToString("dd/MM/yyyy")}  {CurrentSum} ₴ "; }
        }

        public BankAccount() { }
    }
}

