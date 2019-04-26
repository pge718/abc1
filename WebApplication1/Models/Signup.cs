using System;
using System.ComponentModel.DataAnnotations;

namespace Sulekha.Models
{
    public class Signup
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Contact_Number { get; set; }
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string retypePassword { get; set; }
        public string Role { get; set; }
    }
}
