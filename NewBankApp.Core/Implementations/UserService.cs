﻿using MyBankApp.Core.Abstractions;
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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITransactionService _transactionService;

        public UserService(IUnitOfWork unitOfWork, ITransactionService transactionService)
        {
            _unitOfWork = unitOfWork;
            _transactionService = transactionService;
        }

        public async Task<string> CreateUser(User user)
        {
            user.UserId = Utilities.GenerateUniqueId();
            //Creating Account automatically
            Account account = new Account();
            account.FirstName = user.FirstName;
            account.LastName = user.LastName;
            account.OtherName = user.OtherName;
            account.AccountNumber = Utilities.GenerateAccountNumber();
            account.AccountType = user.AccountType;
            account.AccountBalance = 0.0;
            //Sasving Account to database
            _unitOfWork.AccountRepository.CreateAsync(account);
            
            //Saving User to database
            _unitOfWork.UserRepository.CreateAsync(user);
            _unitOfWork.Save();

            return $"User {user.LastName}, {user.FirstName} {user.OtherName} created successfully";
            
        }

        //To be completed later...
        public async Task<string> Login(string email, string userId)
        {
            //Search user by email
            User _user = await _unitOfWork.UserRepository.GetUserByEmailAsync(email);
            User _user2 = await _unitOfWork.UserRepository.GetUserByUserIdAsync(userId);

            if (_user2 != _user)
            {
                return "Invalid user";
            }


            return "User logged in successfully";
        }

        public async Task<object> GetUserByEmailAsync(string email)
        {
            User _user = await _unitOfWork.UserRepository.GetUserByEmailAsync(email);

            if( _user == null )
            {
                return $"user  by email: {email} not found";
            }

            return _user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await _unitOfWork.UserRepository.GetAllUsersAsync();

            return users;
        }

    }
}
