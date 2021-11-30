using System.Collections.Generic;
using System.Threading.Tasks;
using Task4.Models;

namespace Task4.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        
        Task<User> GetUser(string id);

        Task<int> DeleteUser(string id);

        Task AddUser(User user);

        Task UpdateUser(User user);
    }
}
