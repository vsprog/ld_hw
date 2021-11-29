using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Task3.Infrastructure;
using Task3.Models;
using Task3.Repositories;

namespace Task3.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductRepository repository;
        private readonly Cart cart;

        public CartController(IProductRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public async Task<ViewResult> Index(string returnUrl)
        {
            var result = new CartViewModel
            {
                Lines = await cart.Lines(),
                TotalSum = await cart.ComputeTotalValue()
            };

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] string productId)
        {
            Product product = repository.GetProduct(productId);
            
            if (product != null)
            {
                await cart.AddItem(product, 1);
            }

            var result = await GetShortModel();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFromCart([FromBody] string productId)
        {
            Product product = repository.GetProduct(productId);

            if (product != null)
            {
                await cart.RemoveLine(product);
            }

            var result = await GetShortModel();
            return Ok(result);
        }

        [HttpGet]
        public async Task<CartViewModel> GetShortModel() => new CartViewModel
        {
            TotalSum = await cart .ComputeTotalValue(),
            TotalItems = (await cart.Lines()).Sum(x => x.Quantity)
        };
    }
}
