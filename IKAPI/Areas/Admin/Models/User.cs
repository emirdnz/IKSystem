using System.ComponentModel.DataAnnotations;

namespace IKAPI.Areas.Admin.Models
{
    public class User
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ad Alani Zorunludur")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Soyad Alani Zorunludur")]
        public string SurName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Alani Zorunludur")]

        [DataType(DataType.EmailAddress, ErrorMessage = "Duzgun Mail adresi Giriniz")]
        public string Email { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Gsm Alani Zorunludur")]
        public string? PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Alani Zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Role Alani Zorunludur")]
        public string RoleName { get; set; }
    }
}
