using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task4.Contexts;
using Task4.Models;

namespace Task4.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
            this.context.Database.EnsureCreated();
        }

        public Task AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(IUserRepository user)
        {
            throw new NotImplementedException();
        }
    }
}
