using System;
using System.Collections.Generic;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
{
    public class FakeNewsletterSignupRepository : INewsletterSignup
    {
        // instance variables
        private List<NewsletterSignup> emails = new List<NewsletterSignup>();

        // cast List object as IQueryable
        public IQueryable<NewsletterSignup> NewsletterSignup => emails.AsQueryable();

        public void AddSignup(NewsletterSignup email)
        {
            // simulate db primary key
            email.EmailID = emails.Count;
            emails.Add(email);
        }

        public NewsletterSignup GetEmail(string email)
        {
            // find and return the first record with matching email
            NewsletterSignup e = emails.FirstOrDefault(e => e.EmailAddress == email);
            return e;
        }
    }
}
