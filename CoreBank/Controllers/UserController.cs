using Microsoft.AspNetCore.Mvc;
using CoreBank.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CoreBank.Controllers
{
   
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Register a new user",
            Description = "Creates a new user account.")]
        [SwaggerResponse(201, "User created successfully")]
        [SwaggerResponse(400, "Invalid input data")]
        [SwaggerResponse(409, "User already exists")]
        public IActionResult Register([FromBody] RegisterUserDto user)
        {
            // TODO: Add validation, encryption, saving to DB
            return Created("", null);
        }

        [HttpPost("login")]
        [SwaggerOperation(
            Summary = "User login",
            Description = "Provide user credentials and get token.")]
        [SwaggerResponse(200, "Login successful, JWT token returned")]
        [SwaggerResponse(400, "Invalid input data")]
        [SwaggerResponse(401, "Unauthorized - invalid credentials")]
        public IActionResult Login([FromBody] LoginUserDto login)
        {
            // TODO: Validate credentials and generate JWT
            return Ok(new { Token = "jwt-token-placeholder" });
        }
    }

}
