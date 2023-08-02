using MyBankApp.Core.Abstractions;
using MyBankApp.Core.Implementations;
using MyBankApp.Core.ServiceManager.Abstractions;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.ServiceManager.Implementations
{
    public class ServiceManager : IServiceManager
    {
        
        private IAccountService _accountService;
        private ITransactionService _transactionService;
        private IUserService _userService;
        private readonly IUnitOfWork _unitOfWork;

        public ServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IAccountService AccountService => _accountService ?? new AccountService(_unitOfWork);

        public ITransactionService TransactionService => _transactionService?? new TransactionService(_unitOfWork);

        public IUserService UserService => _userService ?? new UserService(_unitOfWork, TransactionService);
    }
}
