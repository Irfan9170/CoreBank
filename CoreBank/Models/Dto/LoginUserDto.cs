using Swashbuckle.AspNetCore.Annotations;

namespace CoreBank.Models.Dto
{
    [SwaggerSchema("DTO for user login")]
    public class LoginUserDto
    {
        [SwaggerSchema("Username used for login")]
        public string UserName { get; set; }

        [SwaggerSchema("Plain-text password")]
        public string Password { get; set; }
    }
}
