using MyBankApp.Repository.Data;
using MyBankApp.Repository.Repository.Abstractions;
using MyBankApp.Repository.Repository.Implementations;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.UnitOfWork.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private IAccountRepository _accountRepository;
        private ITransactionRepository _transactionRepository;
        private IUserRepository _userRepository;
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IAccountRepository AccountRepository => _accountRepository ?? new AccountRepository(_context);
        public ITransactionRepository TransactionRepository => _transactionRepository ?? new TransactionRepository(_context);   
        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_context);

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
