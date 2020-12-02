using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class User
    {
        // Users have legal names and an email address
        // associated with their username.
        [Key]
        public int UserID { get; set; }  // primary key
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
