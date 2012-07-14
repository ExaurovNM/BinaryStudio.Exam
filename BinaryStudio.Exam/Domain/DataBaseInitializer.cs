using System;
using System.Collections.Generic;
using System.Data.Entity;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Domain
{
    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DataBaseContext>
    {

        protected override void Seed(DataBaseContext context)
        {
            context.Users.Add(new User()
                                  {
                                      FirstName = "admin",
                                      LastName = "sdf",
                                      MatrialStatus = "Single"

                                  });
            context.SaveChanges();
        }
    }
}