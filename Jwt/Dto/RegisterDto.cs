using System.ComponentModel.DataAnnotations;

namespace Jwt.Dto
{
    public class RegisterDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
