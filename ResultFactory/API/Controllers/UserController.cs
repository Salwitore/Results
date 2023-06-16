using Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }


        [HttpGet("GetUser")]
        public IActionResult GetUser(int id)
        {
            var result = userService.GetUser(id);

            return StatusCode((int)result.StatusCode, result);
        }

        [HttpGet("ExceptionDeneme")] 
        public IActionResult ExceptionDeneme()
        {
            var result = userService.ExceptionDeneme();

            return StatusCode((int)result.StatusCode, result);
        }

    }
}
