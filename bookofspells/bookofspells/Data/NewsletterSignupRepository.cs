using System;
using System.Collections.Generic;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
{
    public class NewsletterSignupRepository : INewsletterSignup
    {
        // instance variables
        private BookOfSpellsContext context;

        // constructor
        public NewsletterSignupRepository(BookOfSpellsContext c)
        {
            context = c;
        }

        // interface methods
        public IQueryable<NewsletterSignup> NewsletterSignup => context.NewsletterSignup;

        public void AddSignup(NewsletterSignup email)
        {
            // store in database
            context.NewsletterSignup.Add(email);
            context.SaveChanges();
        }

        public NewsletterSignup GetEmail(string email)
        {
            // find and return the first record with matching email
            NewsletterSignup e = context.NewsletterSignup.FirstOrDefault(e => e.EmailAddress == email);
            return e;
        }
    }
}
