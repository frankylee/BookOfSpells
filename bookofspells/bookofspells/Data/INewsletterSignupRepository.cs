using System;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
{
    public interface INewsletterSignup
    {
        // Create
        void AddSignup(NewsletterSignup email);

        // Retrieve
        IQueryable<NewsletterSignup> NewsletterSignup { get; }
        NewsletterSignup GetEmail(string email);

        // Update

        // Delete
    }
}
