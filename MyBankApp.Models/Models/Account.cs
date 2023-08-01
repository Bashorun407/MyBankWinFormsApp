using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankApp.Models.Enums;
using MyBankApp.Models.Models.Common;

namespace MyBankApp.Models.Models
{
    public class Account : BaseEntity
    {
        public string AccountNumber { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        [Column(TypeName = "Money")]
        public double AccountBalance { get; set; }

        //Navigational property
        ICollection<Account> AccountList { get; set;}
    }
}
