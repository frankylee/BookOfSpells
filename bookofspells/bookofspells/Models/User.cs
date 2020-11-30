using System;
namespace bookofspells.Models
{
    public class User
    {
        // Users have legal names and an email address
        // associated with their username.

        public int UserID { get; }  // primary key
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
