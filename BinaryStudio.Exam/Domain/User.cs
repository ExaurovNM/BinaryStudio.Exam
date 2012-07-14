using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BinaryStudio.Exam.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string MatrialStatus { get; set; }

        public virtual List<Interest> Interests { get; set; }
    }

}