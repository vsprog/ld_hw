using System.Linq;
using Task3.Models;

namespace Task3.Abstract
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetAllProducts();

        public Product GetProduct(string id);
    }
}
