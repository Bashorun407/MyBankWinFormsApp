using MyBankApp.Core.Abstractions;
using MyBankApp.Models.Models;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using MyBankApp.Utility.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountService _accountService;

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

        public async Task<string> Withdraw(string accountNumber, string withdrawAmount, string description)
        {
            double withdraw = double.Parse(withdrawAmount);
            Account account = await _accountService.GetAccountByAccountNumber(accountNumber);
            if (account == null)
            {
                return $"Account number: {accountNumber} does not exist";
            }
            if (withdraw > account.AccountBalance)
            {
                return $"Insufficient balance. Enter an amount lower than balance";
            }

            //increment account details
            account.AccountBalance -= withdraw;

            //Create a new transaction
            Transaction transaction = new Transaction();
            transaction.TransactionId = Utilities.GenerateUniqueId();
            transaction.AccountNumber = accountNumber;
            transaction.TransactionType = "Debit";
            transaction.TransactionAmount = withdraw;
            transaction.TransactionDescription = description;
            _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return $" Amount: {withdrawAmount}N withdrawn successfully";
        }


        public async Task<string> Deposit(string accountNumber, string depositAmount, string description)
        {
            double deposit = double.Parse(depositAmount);
            Account account = await _accountService.GetAccountByAccountNumber(accountNumber);
            if (account == null)
            {
                return $"Account number: {accountNumber} does not exist";
            }


            //increment account details
            account.AccountBalance += deposit;

            //Create a new transaction
            Transaction transaction = new Transaction();
            transaction.TransactionId = Utilities.GenerateUniqueId();
            transaction.AccountNumber = accountNumber;
            transaction.TransactionType = "Debit";
            transaction.TransactionAmount = deposit;
            transaction.TransactionDescription = description;

            //Create a new transaction
            _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return $" Amount: {depositAmount}N deposited successfully";
        }


        public async Task<string> TransferAsync(string fromAccount, string toAccount, string amount, string description)
        {

            //Withdraw amount from Sender's account
            Withdraw(fromAccount, amount, description);

            //Send amount to Receiver's account
            Deposit(toAccount, amount, description);

            return $" Amount: {amount} transferred successfully";
        }


        public async Task<string> DeleteTransactionAsync(Transaction transaction)
        {
            Transaction _transaction = await _unitOfWork.TransactionRepository.GetTransactionByTransactionIdAsync(transaction.TransactionId);
            _unitOfWork.TransactionRepository.Delete(_transaction);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return "transaction deleted successfully";
        }

        public async Task<string> DeleteRangeOfTransactionAsync(IEnumerable<Transaction> transactions)
        {
            _unitOfWork.TransactionRepository.DeleteRange(transactions);
            _unitOfWork.Save();
            return "Transactions deleted successfully";
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

        public async Task<IEnumerable<Transaction>> GetTransactionByDateAsync(string transactionDate)
        {
            bool isValidDate = DateOnly.TryParse(transactionDate, out DateOnly dateConverted);

            if(!isValidDate)
            {
                return null;
            }
            IEnumerable<Transaction> transactions = await _unitOfWork.TransactionRepository.GetDailyTransactionAsync(dateConverted);
            return transactions;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactions()
        {
            IEnumerable<Transaction> allTransaction = await _unitOfWork.TransactionRepository.GetAllTransactionsAsync();
            return allTransaction;
        }


        public async Task<string> DeleteTransaction(Transaction transaction)
        {
            Transaction _transaction = await _unitOfWork.TransactionRepository.GetTransactionByTransactionIdAsync(transaction.TransactionId);
            _unitOfWork.TransactionRepository.Delete(_transaction);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return "transaction deleted successfully";
        }

        public Task<IEnumerable<Transaction>> GetTransactionByDateAsync(DateTime transactionDate)
        {
            throw new NotImplementedException();
        }
    }
}
