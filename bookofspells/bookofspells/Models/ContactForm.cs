using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class ContactForm
    {
        // Site visitors can send a contact message without
        // needing a user account.
        [Key]
        public int MessageID { get; set; }  // primary key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
