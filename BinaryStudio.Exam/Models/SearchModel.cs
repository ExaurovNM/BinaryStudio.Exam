using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudio.Exam.Domain;

namespace BinaryStudio.Exam.Models
{
    public class SearchModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string MatrialStatus { get; set; }

        public IList<Interest> Interests { get; set; } 
    }
}