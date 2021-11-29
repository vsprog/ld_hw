using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Task3.Models;

namespace Task3.Infrastructure
{
    public class Cart
    {
        private readonly ConcurrentDictionary<string, CartLine> lineCollection = new ConcurrentDictionary<string, CartLine>();

        public virtual async Task AddItem(Product product, int quantity)
        {
            await Task.Run(() => {
                lineCollection.TryGetValue(product.Id, out CartLine line);
                
                if (line == null)
                {
                    lineCollection.TryAdd(product.Id, new CartLine
                    {
                        Product = product,
                        Quantity = quantity
                    });
                }
                else
                {
                    line.Quantity += quantity;
                }
            });
        }

        public virtual async Task RemoveLine(Product product) => await Task.Run(() => lineCollection.TryRemove(product.Id, out _));

        public virtual async Task<decimal> ComputeTotalValue() => await Task.Run(() => lineCollection.Sum(p => p.Value.Product.Price * p.Value.Quantity));

        //public virtual void Clear() => lineCollection.Clear();

        public virtual async Task<IEnumerable<CartLine>> Lines() => await Task.Run(() => lineCollection.ToList<KeyValuePair<string, CartLine>>().Select(p => p.Value));
    }
}
