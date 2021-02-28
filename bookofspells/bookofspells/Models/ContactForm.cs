using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class ContactForm
    {
        [Key]
        public int MessageID { get; set; }  // primary key

        [Required(ErrorMessage = "Name cannot be empty.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name must be 1-50 characters.")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Name may not contain special characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address cannot be empty.")]
        [StringLength(254, MinimumLength = 5, ErrorMessage = "Email address must be 5-254 characters.")]
        [RegularExpression(@"^[a-zA-Z]+([a-zA-Z0-9]?[_\.]??)+[a-zA-Z0-9]+@[a-zA-Z]+([a-zA-Z0-9]?[-]??)+\.[a-zA-Z]+$",
            ErrorMessage = "Email address must begin with a letter and may only contain letters, underscores, periods, and the at symbol. Please follow the format: email@domain.com")]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Required(ErrorMessage = "An empty message cannot be sent.")]
        [StringLength(8000, MinimumLength = 10, ErrorMessage = "Message must be at least 10 characters.")]
        public string Message { get; set; }
    }
}
