using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Range(100000, 999999, ErrorMessage ="You need to enter a valid EmployeeIds")]
        public int EmpleyeeId { get; set; }

        [Display(Name = "First Name ")]
        [Required(ErrorMessage = "You need to give us your first name. ")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name ")]
        [Required(ErrorMessage = "You need to give us your last name. ")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your email adresss ")]
        public string EmailAdress { get; set; }

        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "You need to provide a long enought password.")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match. s")]
        public string ConfirmPassword { get; set; }
    }
}