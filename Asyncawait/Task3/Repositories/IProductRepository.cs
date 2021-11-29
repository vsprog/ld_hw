using System.Linq;
using Task3.Models;

namespace Task3.Repositories
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAllProducts();

        Product GetProduct(string id);
    }
}
