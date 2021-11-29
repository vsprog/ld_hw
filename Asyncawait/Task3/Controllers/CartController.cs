using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        public ViewResult Index(string returnUrl)
        {
            var result = new CartViewModel
            {
                Lines = cart.Lines,
                TotalSum = cart.ComputeTotalValue()
            };

            return View(result);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] string productId)
        {
            Product product = repository.GetProduct(productId);
            
            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            var result = GetShortModel();
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult RemoveFromCart([FromBody] string productId)
        {
            Product product = repository.GetProduct(productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }

            var result = GetShortModel();
            return Ok(result);
        }

        [HttpGet]
        public CartViewModel GetShortModel() => new CartViewModel
        {
            TotalSum = cart.ComputeTotalValue(),
            TotalItems = cart.Lines.Sum(x => x.Quantity)
        };
    }
}
