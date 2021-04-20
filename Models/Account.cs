using System;
using System.ComponentModel.DataAnnotations;

namespace Macintosh_OOP.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string password  { get; set; }
        public string AccessLevel { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
