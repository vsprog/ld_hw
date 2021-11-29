using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task3.Models;
using Task3.Repositories;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository repository;

        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> result = repository.GetAllProducts();
            return View(result);
        }
    }
}
