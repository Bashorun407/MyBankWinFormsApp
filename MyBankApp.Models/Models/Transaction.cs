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
    public class Transaction : BaseEntity
    {
        public string? TransactionId { get; set; }
        //Debit or Credit or Transfer
        public TransactionType TransactionType { get; set; }
        public string AccountNumber { get; set; }

        [Column(TypeName = "Money")]
        public double TransactionAmount { get; set; }

        public string TransactionDescription { get; set; }
    }
}
