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
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Account> _account;

        public AccountRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _account = _context.Set<Account>();
        }

        public async Task<Account> GetAccountByAccountNumberAsync(string accountNumber)
        {
            Account account = await _account.FindAsync(accountNumber);
            return account;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            IEnumerable<Account> accounts =  await _account.ToListAsync();
            return accounts;
        }

    }
}
