using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }  // primary key

        [Required(ErrorMessage = "Username cannot be empty.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Username must be 5-30 characters.")]
        [RegularExpression(@"^[a-zA-Z]+([a-zA-Z0-9]?|[_\.]??)+[a-zA-Z0-9]+$",
            ErrorMessage = "Username must begin with a letter and may only contain letters, underscores, and periods.")]
        public string Username { get; set; }

        //[Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "First name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "First name may not contain special characters.")]
        public string FirstName { get; set; }

        //[Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Last name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Last name may not contain special characters.")]
        public string LastName { get; set; }

        //[Required]
        [StringLength(254, MinimumLength = 5, ErrorMessage = "Email address must be 5-254 characters.")]
        [RegularExpression(@"^[a-zA-Z]+([a-zA-Z0-9]?[_\.]??)+[a-zA-Z0-9]+@[a-zA-Z]+([a-zA-Z0-9]?[-]??)+\.[a-zA-Z]+$",
            ErrorMessage = "Email address must begin with a letter and may only contain letters, underscores, periods, and the at symbol.")]
        public string EmailAddress { get; set; }
    }
}
