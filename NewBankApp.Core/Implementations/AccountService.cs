using MyBankApp.Models.DTO.AccountDto;
using MyBankApp.Models.Models;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Implementations
{
    public class AccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateAccount(Account account)
        {
             await _unitOfWork.AccountRepository.CreateAsync(account);
            //_unitOfWork.SaveChanges();
            return "Account created!";
        }

        public async Task<Account> GetAccountByAccountNumber(string accountNumber)
        {
            Account acct = await _unitOfWork.AccountRepository.GetAccountByAccountNumberAsync(accountNumber);
            return acct;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            IEnumerable<Account> accounts = await _unitOfWork.AccountRepository.GetAllAccountsAsync();
            return accounts;
        }

       public async Task<string> UpdateAccount(Account account)
        {
            Account accountToUpdate = await _unitOfWork.AccountRepository.GetAccountByAccountNumberAsync(account.AccountNumber);
                if(accountToUpdate == null)
            {
                return $"Account with account: {account.AccountNumber} does not exist";
            }
            _unitOfWork.AccountRepository.Update(account);

            return "Account updated successfully";
        }

        public async Task<string> DeleteAccount(Account account)
        {
            Account accountToUpdate = await _unitOfWork.AccountRepository.GetAccountByAccountNumberAsync(account.AccountNumber);
            if (accountToUpdate == null)
            {
                return $"Account with account: {account.AccountNumber} does not exist";
            }
            _unitOfWork.AccountRepository.Delete(account);

            return "Account deleted successfully";
        }
    }
}
