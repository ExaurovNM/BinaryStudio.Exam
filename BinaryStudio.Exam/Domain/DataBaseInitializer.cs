using System;
using System.Collections.Generic;
using System.Data.Entity;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Domain
{
    public class DataBaseInitializer
    {
        public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
        {
            protected override void Seed(DataBaseContext context)
            {
                context.Interests.Add(new Interest()
                                          {
                                              Id = 1,
                                              InterestName = "Programming"
                                          });
                context.Users.Add(new User()
                                      {
                                          Id = 1,
                                          FirstName = "Vasya",
                                          LastName = "Shupin",
                                          Gender = "Male",
                                          Mail = "vaya@as.ss",
                                          MatrialStatus = "single",
                                          DateOfBirth = new DateTime(2000, 10, 10),
                                      });
                context.SaveChanges();
            }
        }
    }
}