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

        [Required]
        [StringLength(254, MinimumLength = 5, ErrorMessage = "Email address must be 5-254 characters.")]
        [RegularExpression(@"^[a-zA-Z]+([a-zA-Z0-9]?[_\.]??)+[a-zA-Z0-9]+@[a-zA-Z]+([a-zA-Z0-9]?[-]??)+\.[a-zA-Z]+$",
            ErrorMessage = "Email address must begin with a letter and may only contain letters, underscores, periods, and the at symbol.")]
        public string EmailAddress { get; set; }
    }
}
