using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibManApp.Web.ViewModels.AccountViewModel
{
    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "FirstName")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string FirstName { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "LastName")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string LastName { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Street")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string Street { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "City")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string City { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Province")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string Province { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Country")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string Country { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name = "PostalCode")]
       // [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public string PostalCode { get; set;  }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
       // [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} character long.")]
        public int PhoneNumber { get; set; }
    }
}
