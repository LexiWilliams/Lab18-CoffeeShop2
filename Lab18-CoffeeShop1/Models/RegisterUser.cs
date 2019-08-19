using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18_CoffeeShop1.Models
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage ="Invalid email"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required"),DataType(DataType.Password),RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",
            ErrorMessage ="Invalid Password: Must contain 1 capital letter, 1 number, and at least 8 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Birthday is required"), DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [StringLength(6)]
        public string ZipCode { get; set; }
    }
}
