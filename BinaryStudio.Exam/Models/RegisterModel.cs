using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryStudio.Exam.Domain;

namespace BinaryStudio.Exam.Models
{
    public class RegisterModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a first name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name!")]
        public string LastName { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please, enter a  mail!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please, enter a correct mail!")]
        public string Mail { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string MatrialStatus { get; set; }

        public List<Interest> Interests { get; set; }
    }
}