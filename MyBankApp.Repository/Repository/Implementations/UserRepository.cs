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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<User> _user;

        public UserRepository(AppDbContext context) : base(context) 
        {
            _context = context;
            _user = _context.Set<User>();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await _user.ToListAsync();
            return users;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            User user = await _user.FindAsync(email);
            return user;
        }

        public async Task<User> GetUserByPhoneNumberAsync(string phoneNumber)
        {
            User user = await _user.FindAsync(phoneNumber);
            return user;
        }

        public async Task<User> GetUserByUserIdAsync(string userId)
        {
            User user = await _user.FindAsync(userId);
            return user;
        }
    }
}
