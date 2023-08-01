using MyBankApp.Models.Models;
using MyBankApp.Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.Repository.Abstractions
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Task<Account> GetAccountByAccountNumberAsync(string accountNumber);
        Task<IEnumerable<Account>> GetAccountByUserIdAsync(string userId);
        Task<IEnumerable<Account>> GetAllAccountsAsync();
    }
}
