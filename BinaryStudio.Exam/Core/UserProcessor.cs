using System;
using System.Linq;
using BinaryStudio.Exam.Domain;
using BinaryStudio.Exam.Helpers;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Core
{
    public class UserProcessor : IUserProcessor
    {
        public bool CreateUser (RegisterModel register)
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                if (dataBaseContext.Users.ToList().Any(it => (it.FirstName.ToLower().Equals(register.FirstName.ToLower()) &&
                                                             it.LastName.ToLower().Equals(register.LastName.ToLower())) ||
                                                             it.Mail.ToLower().Equals(register.ToString().ToLower())))
                {
                    return false;
                }
                try
                {
                    Hasher hasher = new Hasher();
                    dataBaseContext.Users.Add(new User()
                    {
                        FirstName = register.FirstName,
                        LastName = register.LastName,
                        DateOfBirth = register.DateOfBirth,
                        Password = hasher.HashPassword(register.Mail,register.Password),
                        Gender = register.Gender,
                        MatrialStatus = register.MatrialStatus,
                        Mail = register.Mail,
                    });
                    dataBaseContext.SaveChanges();
                }
                catch (Exception)
                {

                    return false;
                }
                
                return true;
            }

        }

        public bool ValidateUser(string email, string password)
        {
            DataBaseContext dataBaseContext = new DataBaseContext();

            Hasher hasher = new Hasher();
            string haS = hasher.HashPassword(email, password);
            if (dataBaseContext.Users.Any(it => it.Mail.Equals(email.ToLower()) &&
                                               it.Password.Equals(haS)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public User GetUserByEmail(string email)
        {
            DataBaseContext dataBaseContext = new DataBaseContext();
            return dataBaseContext.Users.ToList().Single(it => it.Mail.ToLower().
                                                                   Equals(email.ToLower()));
        }
    }
}