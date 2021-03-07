using System;
using System.Collections.Generic;
using System.Linq;

namespace bookofspells.Models
{
    public class NewsletterSignupRepository : INewsletterSignup
    {
        private BookOfSpellsContext context;

        public NewsletterSignupRepository(BookOfSpellsContext c)
        {
            context = c;
        }

        // Retrieve all emails in the database
        public IQueryable<NewsletterSignup> NewsletterSignup => context.NewsletterSignup;
        // Retrieve a unique email by address
        public NewsletterSignup GetEmail(string email)
        {
            // find and return the first record with matching email
            NewsletterSignup e = context.NewsletterSignup.FirstOrDefault(e => e.EmailAddress.Equals(email));
            return e;
        }

        public void AddSignup(NewsletterSignup email)
        {
            // Confirm email is unique before adding
            var uniqueEmail = context.NewsletterSignup.FirstOrDefault(e => e.EmailAddress.Equals(email.EmailAddress));
            // Confirm email was not retreived
            if (uniqueEmail == null)
            {
                // Create unique email to database and save changes
                uniqueEmail = email;
                context.NewsletterSignup.Add(uniqueEmail);
                context.SaveChanges();
            }
        }

        public void UpdateEmail(string oldAddress, string newAddress)
        {
            // First, confirm original email exists
            var originalEmail = context.NewsletterSignup.FirstOrDefault(e => e.EmailAddress.Equals(oldAddress));
            // Confirm email was retrieved
            if (originalEmail != null)
            {
                // Update email in the database and save changes
                originalEmail.EmailAddress = newAddress;
                context.NewsletterSignup.Update(originalEmail);
                context.SaveChanges();
            }
        }

        public void DeleteEmail(string email)
        {
            // Confirm email exists in the database
            var deleteEmail = context.NewsletterSignup.FirstOrDefault(e => e.EmailAddress.Equals(email));
            // Confirm email was retrieved before delete
            if (deleteEmail != null)
            {
                // Remove email from the database and save changes
                context.NewsletterSignup.Remove(deleteEmail);
                context.SaveChanges();
            }
        }
    }
}
