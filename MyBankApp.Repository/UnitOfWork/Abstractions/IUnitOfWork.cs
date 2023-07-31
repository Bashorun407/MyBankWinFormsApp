using MyBankApp.Repository.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.UnitOfWork.Abstractions
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; }
        ITransactionRepository TransactionRepository { get; }
        IUserRepository UserRepository { get; }
        Task Save();
        void Dispose();
    }
}
