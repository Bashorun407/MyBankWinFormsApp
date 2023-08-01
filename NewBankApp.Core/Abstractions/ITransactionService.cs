using MyBankApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Abstractions
{
    public interface ITransactionService
    {
        Task<string> CreateTransactionAsync(Transaction transaction);
        Task<string> DeleteTransaction(Transaction transaction);
        Task<object> GetTransactionByTransactionIdAsync(string transactionId);
        Task<IEnumerable<Transaction>> GetTransactionByDateAsync(DateTime transactionDate);
        Task<IEnumerable<Transaction>> GetTransactionByAccountNumberAsync(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllTransactions();
    }
}
