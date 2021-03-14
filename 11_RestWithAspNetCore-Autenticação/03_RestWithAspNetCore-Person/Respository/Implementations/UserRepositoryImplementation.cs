using _03_RestWithAspNetCore_Person.Data.VO;
using _03_RestWithAspNetCore_Person.Model;
using _03_RestWithAspNetCore_Person.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace _03_RestWithAspNetCore_Person.Respository.Implementations
{
    public class UserRepositoryImplementation : IUserRepository
    {
        private readonly MySQLContext _context;
        public UserRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }
        public User ValidationCredentials(UserVO user)
        {
            var pass = ComputerHash(user.Password, new SHA256CryptoServiceProvider());
            return _context.Users
                .FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }

        public User RefreshUserInfo(User user)
        {
            if (!_context.Users.Any(u => u.ID.Equals(user.ID))) return null;
            var result = _context.Users.SingleOrDefault(u => u.ID.Equals(user.ID));
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
             }

            return result;
        }

        private string ComputerHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}
