using MyBankApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Core.Abstractions
{
    public interface IUserService
    {
        Task<string> CreateUser(User user);
        Task<object> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<string> Login(string email, string userId);
    }
}
