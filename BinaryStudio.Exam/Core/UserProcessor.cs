using System;
using System.Linq;
using BinaryStudio.Exam.Domain;
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
                    dataBaseContext.Users.Add(new User()
                    {
                        FirstName = register.FirstName,
                        LastName = register.LastName,
                        DateOfBirth = register.DateOfBirth,
                        //TODO: Hash
                        Password = register.Password,
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
            try
            {
                dataBaseContext.Users.Single(it => it.Mail == email &&
                                                   it.Password == password);
                return true;
            }
            catch (Exception)
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