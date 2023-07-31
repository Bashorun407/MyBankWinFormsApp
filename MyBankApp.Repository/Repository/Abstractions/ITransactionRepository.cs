using MyBankApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.Repository.Abstractions
{
    public interface ITransactionRepository : IGenericRepository<Transaction>
    {
        Task<Transaction> GetTransactionByTransactionIdAsync(string transactionId);
        Task<Transaction> GetTransactionByAccountNumberAsync(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
    }
}
