using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class NewsletterSignup
    {
        // Site visitors can enter a valid email address to
        // signup for regularly emailed newsletters
        [Key]
        public int EmailID { get; set; }  // primary key
        public string EmailAddress { get; set; }
    }
}
