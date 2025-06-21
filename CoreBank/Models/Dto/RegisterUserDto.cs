using Swashbuckle.AspNetCore.Annotations;
namespace CoreBank.Models.Dto
{
    [SwaggerSchema("DTO for registering a new user")]
    public class RegisterUserDto
    {
        [SwaggerSchema("Username for login. Must be unique.")]
        public string UserName { get; set; }

        [SwaggerSchema("Plain-text password. Will be encrypted before saving.")]
        public string Password { get; set; }
    }
}
