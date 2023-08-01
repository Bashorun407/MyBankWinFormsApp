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
    public class TransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountService _accountService;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //Redundant CreateTransactionAsync method
        /*public async Task<string> CreateTransactionAsync(Transaction transaction)
        {

            await _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return "Transaction successful";


        }*/

        public async Task<string> Withdraw(string accountNumber, double withdrawAmount, string description)
        {
            Account account = await _accountService.GetAccountByAccountNumber(accountNumber);
            if (account == null)
            {
                return $"Account number: {accountNumber} does not exist";
            }
            if (withdrawAmount > account.AccountBalance)
            {
                return $"Insufficient balance. Enter an amount lower than balance";
            }

            //increment account details
            account.AccountBalance -= withdrawAmount;

            //Create a new transaction
            Transaction transaction = new Transaction();
            transaction.TransactionId = Utilities.GenerateUniqueId();
            transaction.AccountNumber = accountNumber;
            transaction.TransactionType = "Debit";
            transaction.TransactionAmount = withdrawAmount;
            transaction.TransactionDescription = description;
            _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return $" Amount: {withdrawAmount}N withdrawn successfully";
        }


        public async Task<string> Deposit(string accountNumber, double depositAmount, string description)
        {
            Account account = await _accountService.GetAccountByAccountNumber(accountNumber);
            if (account == null)
            {
                return $"Account number: {accountNumber} does not exist";
            }


            //increment account details
            account.AccountBalance += depositAmount;

            //Create a new transaction
            Transaction transaction = new Transaction();
            transaction.TransactionId = Utilities.GenerateUniqueId();
            transaction.AccountNumber = accountNumber;
            transaction.TransactionType = "Debit";
            transaction.TransactionAmount = depositAmount;
            transaction.TransactionDescription = description;

            //Create a new transaction
            _unitOfWork.TransactionRepository.CreateAsync(transaction);
            _unitOfWork.Save();

            return $" Amount: {depositAmount}N deposited successfully";
        }


        public async Task<string> TransferAsync(string fromAccount, string toAccount, double amount, string description)
        {

            //Withdraw amount from Sender's account
            Withdraw(fromAccount, amount, description);

            //Send amount to Receiver's account
            Deposit(toAccount, amount, description);

            return $" Amount: {amount} transferred successfully";
        }


        public async Task<string> DeleteTransactionAsync(Transaction transaction)
        {
             _unitOfWork.TransactionRepository.Delete(transaction);
            _unitOfWork.Save();
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

        public async Task<IEnumerable<Transaction>> GetTransactionByDateAsync(DateOnly transactionDate)
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
