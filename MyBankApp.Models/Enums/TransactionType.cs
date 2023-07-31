using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Models.Enums
{
    public enum TransactionType
    {
        [Description("Transaction type: ")]
        Credit = 1, Debit
    }
}
