using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBankApp.Models.Models.Common;

namespace MyBankApp.Models.Models
{
    public class User : BaseEntity
    {
        public string? UserId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        //Navigational property
        List<Account> Accounts { get; set; }
        List<Transaction> Transactions { get; set; }
    }
}
