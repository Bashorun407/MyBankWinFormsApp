using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Models.Enums
{
    public enum AccountType
    {
        [Description("Account type: ")]
        Savings = 1, Current, FixedDeposit
    }
}
