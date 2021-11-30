using Microsoft.EntityFrameworkCore;
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

        public async Task AddUser(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        public async Task<int> DeleteUser(string id)
        {
            int result = 0;
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));

            if (user != null)
            {
                context.Users.Remove(user);
                result = await context.SaveChangesAsync();
            }

            return result;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUser(string id)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Id.Equals(id));
        }

        public async Task UpdateUser(User user)
        {
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
