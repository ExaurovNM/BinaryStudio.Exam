using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
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

        public string Password { get; set; }

        [Required(ErrorMessage = "Please, enter a  mail!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please, enter a correct mail!")]
        public string Mail { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string MatrialStatus { get; set; }

        public List<Interest> Interests { get; set; }
    }
}