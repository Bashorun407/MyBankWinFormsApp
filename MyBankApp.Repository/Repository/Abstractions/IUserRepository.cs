using MyBankApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBankApp.Repository.Repository.Abstractions
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByUserIdAsync(string userId);
        Task<User> GetUserByPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}
