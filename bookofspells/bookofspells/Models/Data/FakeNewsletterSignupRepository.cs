using System;
using System.Collections.Generic;
using System.Linq;

namespace bookofspells.Models
{
    public class FakeNewsletterSignupRepository : INewsletterSignup
    {
        // instance variables
        private List<NewsletterSignup> emails = new List<NewsletterSignup>();

        // cast List object as IQueryable
        public IQueryable<NewsletterSignup> NewsletterSignup => emails.AsQueryable();

        public NewsletterSignup GetEmail(string email)
        {
            // find and return the first record with matching email
            NewsletterSignup e = emails.FirstOrDefault(e => e.EmailAddress.Equals(email));
            return e;
        }

        public void AddSignup(NewsletterSignup email)
        {
            // simulate db primary key
            email.EmailID = emails.Count + 1;
            emails.Add(email);
        }
        
        public void UpdateEmail(string oldAddress, string newAddress)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmail(string email)
        {
            // First find email if exists
            var e = emails.FirstOrDefault(e => e.EmailAddress == email);
            // If it exists, then remove from list
            if (e.EmailAddress != null)
                emails.Remove(e);
        }
    }
}
