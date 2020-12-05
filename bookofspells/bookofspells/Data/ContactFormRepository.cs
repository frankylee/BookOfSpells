using System;
using System.Collections.Generic;
using System.Linq;
using bookofspells.Models;
using Microsoft.EntityFrameworkCore;

namespace bookofspells.Data
{
    public class ContactFormRepository : IContactFormRepository
    {
        // instance variables
        private BookOfSpellsContext context;

        // constructor
        public ContactFormRepository(BookOfSpellsContext c)
        {
            context = c;
        }

        // interface methods
        public IQueryable<ContactForm> ContactForm => context.ContactForm;

        public void AddMessage(ContactForm message)
        {
            // store in database
            context.ContactForm.Add(message);
            context.SaveChanges();
        }

        List<ContactForm> IContactFormRepository.GetByEmail(string email)
        {
            // find and return a list of all messages with matching email
            List<ContactForm> messagesFromUser = context.ContactForm.Where(m => m.Email.Equals(email)).ToList();
            return messagesFromUser;
        }
    }
}
