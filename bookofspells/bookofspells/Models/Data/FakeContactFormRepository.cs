using System;
using System.Collections.Generic;
using System.Linq;

namespace bookofspells.Models
{
    public class FakeContactFormRepository : IContactFormRepository
    {
        // instance variables
        private List<ContactForm> messages = new List<ContactForm>();

        // cast List object as IQueryable
        public IQueryable<ContactForm> ContactForm => messages.AsQueryable();


        public void AddMessage(ContactForm message)
        {
            // simulate db primary key
            message.MessageID = messages.Count;
            messages.Add(message);
        }

        public List<ContactForm> GetByEmail(string email)
        {
            // find and return a list of all messages with matching email
            List<ContactForm> messagesFromUser = messages.FindAll(m => m.Email.Equals(email));
            return messagesFromUser;
        }
    }
}
