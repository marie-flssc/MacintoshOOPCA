using System;
using System.ComponentModel.DataAnnotations;

namespace Macintosh_OOP.Models
{
    public class Account
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string password  { get; set; }
    }
}
