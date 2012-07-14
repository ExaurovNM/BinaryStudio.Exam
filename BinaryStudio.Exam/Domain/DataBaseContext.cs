using System.Data.Entity;
using BinaryStudio.Exam.Models;

namespace BinaryStudio.Exam.Domain
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Interest> Interests { get; set; }
    }
}