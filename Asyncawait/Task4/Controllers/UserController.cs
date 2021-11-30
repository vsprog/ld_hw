using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Task4.Models;
using Task4.Repositories;

namespace Task4.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await repository.GetAllUsers();
                return Ok(users);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(string userId)
        {
            try
            {
                var user = await repository.GetUser(userId);

                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(User model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await repository.AddUser(model);
                    return Ok();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            int result = 0;

            try
            {
                result = await repository.DeleteUser(userId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        public async Task<IActionResult> UpdateUser(User model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await repository.UpdateUser(model);
                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }
                    return BadRequest();
                }
            }
            return BadRequest();
        }
    }
}
