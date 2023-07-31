using Microsoft.EntityFrameworkCore;
using MyBankApp.Models.Models;
using MyBankApp.Repository.Data;
using MyBankApp.Repository.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.Repository.Implementations
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Transaction> _transaction;
        public TransactionRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _transaction = _context.Set<Transaction>();
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync()
        {
            IEnumerable<Transaction> transactions = await _transaction.ToListAsync();
            return transactions;
        }

        public async Task<Transaction> GetTransactionByAccountNumberAsync(string accountNumber)
        {
            Transaction transaction = await _transaction.FindAsync(accountNumber);
            return transaction;
        }

        public async Task<Transaction> GetTransactionByTransactionIdAsync(string transactionId)
        {
            Transaction transaction = await _transaction.FindAsync(transactionId);
            return transaction;
        }
    }
}
