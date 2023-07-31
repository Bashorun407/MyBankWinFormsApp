using MyBankApp.Models.Models;
using MyBankApp.Repository.UnitOfWork.Abstractions;
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

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateTransaction(Transaction transaction)
        {
            await _unitOfWork.TransactionRepository.CreateAsync(transaction);

            return "Transaction successful";
        }
    }
}
