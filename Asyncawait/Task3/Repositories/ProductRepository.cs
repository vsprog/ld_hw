using System.Linq;
using Task3.Abstract;
using Task3.Contexts;
using Task3.Models;

namespace Task3.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductRepository(AppDbContext context)
        {
            this.context = context;
            this.context.Database.EnsureCreated();
        }

        public IQueryable<Product> GetAllProducts() => context.Products;

        public Product GetProduct(string id)
        {
            return context.Products.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}
