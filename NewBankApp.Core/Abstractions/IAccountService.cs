using MyBankApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Abstractions
{
    public interface IAccountService
    {
        Task<string> CreateAccount(Account account);
        Task<Account> GetAccountByAccountNumber(string accountNumber);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<string> UpdateAccount(Account account);
        Task<string> DeleteAccount(Account account);
    }
}
