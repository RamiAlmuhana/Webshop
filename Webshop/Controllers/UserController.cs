using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = new List<User>
            {
                new User
                {
                    id = 1,
                    email = "test@test.com",
                    firstName = "test",
                    lastName = "test"
                }
            };
            return Ok(users);
        }
    }
}
