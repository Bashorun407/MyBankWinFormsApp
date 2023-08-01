using MyBankApp.Models.Models;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Implementations
{
    public class TransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateTransactionAsync(Transaction transaction)
        {
            await _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return "Transaction successful";


        }

        public async Task<string> DeleteTransactionAsync(Transaction transaction)
        {
             _unitOfWork.TransactionRepository.Delete(transaction);
            _unitOfWork.Save();
            return "transaction deleted successfully";
        }

        public async Task<object> GetTransactionByTransactionIdAsync(string transactionId)
        {
            Transaction _transaction = await _unitOfWork.TransactionRepository.GetTransactionByTransactionIdAsync(transactionId);

            if (_transaction == null)
            {
                return $"transaction with transaction id: {transactionId} not found";
            }

            return _transaction;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionByAccountNumberAsync(string accountNumber)
        {
            IEnumerable<Transaction> transactions = await _unitOfWork.TransactionRepository.GetTransactionByAccountNumberAsync(accountNumber);
            return transactions;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionByDateAsync(DateTime transactionDate)
        {
            IEnumerable<Transaction> transactions = await _unitOfWork.TransactionRepository.GetDailyTransactionAsync(transactionDate);
            return transactions;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            IEnumerable<Transaction> allTransaction = await _unitOfWork.TransactionRepository.GetAllTransactionsAsync();
            return allTransaction;
        }

       
    }
}
