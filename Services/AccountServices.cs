using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Macintosh_OOP.Helpers;
using Macintosh_OOP.Models;
using Macintosh_OOP.Data;


namespace Macintosh_OOP.Services
{
    public interface IAccountServices
    {
        Account Authenticate(string username, string password);
        IEnumerable<Account> GetAll();
        Account GetById(int id);
        Account Create(Account account, string password);
        void Delete(int id);
        void Update(Account user, string currentPassword, string newPassword, string confirmNewPassword);
    }

    public class AccountServices : IAccountServices
    {
        private Context _context;

        public AccountServices(Context context)
        {
            _context = context;
        }

        public Account Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            var user = _context.Account.FirstOrDefault(x => x.Username == username) ?? null;

            // check if username exists
            if (user == null)
            {
                return null;
            }

            // Granting access if the hashed password in the database matches with the password(hashed in computeHash method) entered by user.
            if (computeHash(password) != user.password)
            {
                return null;
            }
            return user;
        }

        public IEnumerable<Account> GetAll()
        {
            return _context.Account;
        }

        public Account GetById(int id)
        {
            return _context.Account.Find(id);
        }

        public Account Create(Account account, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new AppException("Password is required");
            }

            if (_context.Account.Any(x => x.Username == account.Username))
            {
                throw new AppException("Username \"" + account.Username + "\" is already taken");
            }

            //Saving hashed password into Database table
            account.password = computeHash(password);
            account.AccessLevel = null;
            account.Created = DateTime.UtcNow;
            account.LastModified = DateTime.UtcNow;

            _context.Account.Add(account);
            _context.SaveChanges();

            return account;
        }

        public void Update(Account userParam, string currentPassword = null, string password = null, string confirmPassword = null)
        {
            //Find the user by Id
            var user = _context.Account.Find(userParam.Id);

            if (user == null)
            {
                throw new AppException("User not found");
            }
            // update user properties if provided
            if (!string.IsNullOrWhiteSpace(userParam.Username) && userParam.Username != user.Username)
            {
                // throw error if the new username is already taken
                if (_context.Account.Any(x => x.Username == userParam.Username))
                {
                    throw new AppException("Username " + userParam.Username + " is already taken");
                }
                else
                {
                    user.Username = userParam.Username;
                    user.LastModified = DateTime.UtcNow;
                }
            }
            if (!string.IsNullOrWhiteSpace(userParam.FirstName))
            {
                user.FirstName = userParam.FirstName;
                user.LastModified = DateTime.UtcNow;
            }
            if (!string.IsNullOrWhiteSpace(userParam.LastName))
            {
                user.LastName = userParam.LastName;
                user.LastModified = DateTime.UtcNow;
            }
            if (!string.IsNullOrWhiteSpace(currentPassword))
            {
                if (computeHash(currentPassword) != user.password)
                {
                    throw new AppException("Invalid Current password!");
                }

                if (currentPassword == password)
                {
                    throw new AppException("Please choose another password!");
                }

                //Updating hashed password into Database table
                user.password = computeHash(password);
                user.LastModified = DateTime.UtcNow;
            }

            _context.Account.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Account.Find(id);
            if (user != null)
            {
                _context.Account.Remove(user);
                _context.SaveChanges();
            }
        }

        private static string computeHash(string Password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            var input = md5.ComputeHash(Encoding.UTF8.GetBytes(Password));
            var hashstring = "";
            foreach (var hashbyte in input)
            {
                hashstring += hashbyte.ToString("x2");
            }
            return hashstring;
        }

        IEnumerable<Account> IAccountServices.GetAll()
        {
            throw new NotImplementedException();
        }

        Account IAccountServices.GetById(int id)
        {
            throw new NotImplementedException();
        }

    }
}