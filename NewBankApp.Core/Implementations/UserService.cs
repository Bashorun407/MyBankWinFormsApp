using MyBankApp.Core.Abstractions;
using MyBankApp.Models.Models;
using MyBankApp.Repository.UnitOfWork.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Implementations
{
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> CreateUser(User user)
        {
            _unitOfWork.UserRepository.CreateAsync(user);

            return $"User {user.LastName}, {user.FirstName} {user.OtherName} created successfully";
            _unitOfWork.Save();
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
