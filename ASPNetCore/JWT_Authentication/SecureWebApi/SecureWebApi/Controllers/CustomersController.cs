using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SecureWebApi.Interfaces;
using SecureWebApi.Requests;
using System.Threading.Tasks;

namespace SecureWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Username) || string.IsNullOrEmpty(loginRequest.Password))
            {
                return BadRequest("Missing login Details");
            }
            var loginResponse = await _customerService.Login(loginRequest);
            if (loginResponse == null)
            {
                return BadRequest($"Invalid Credentials");
            }
            return Ok(loginResponse);
        }
    }
}
