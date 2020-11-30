using System;
namespace bookofspells.Models
{
    public class NewsletterSignup
    {
        // Site visitors can enter a valid email address to
        // signup for regularly emailed newsletters

        public int EmailID { get; }  // primary key
        public string EmailAddress { get; set; }
    }
}
