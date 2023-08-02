using MyBankApp.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.ServiceManager.Abstractions
{
    public interface IServiceManager
    {
        IAccountService AccountService { get; }
        ITransactionService TransactionService { get; }
        IUserService UserService { get; }

    }
}