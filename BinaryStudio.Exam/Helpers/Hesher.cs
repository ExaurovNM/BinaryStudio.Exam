using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BinaryStudio.Exam.Helpers
{
    public  class Hasher
    {
        public string HashPassword(string email, string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(password+email);
            Byte[] encodedBytes = md5.ComputeHash(originalBytes);

            return BitConverter.ToString(encodedBytes);
        }


    }
}