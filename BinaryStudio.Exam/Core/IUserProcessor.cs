using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BinaryStudio.Exam.Domain;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Core
{
    public interface IUserProcessor
    {
        bool CreateUser(RegisterModel register);
        
        bool ValidateUser(string email, string password);

        User GetUserByEmail(string email);

    }


}