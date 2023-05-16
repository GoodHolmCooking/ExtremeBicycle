using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ExtremeBicycle.Models
{
    public class LoginRequest
    {

        [Required(ErrorMessage = "username Required")]
        public string? User { get; set; }

        [Required(ErrorMessage = "password")]
        [PasswordPropertyText] //basically DataType.EmailAddress but shorthand
        public string? Pass { get; set; }
    }
}
