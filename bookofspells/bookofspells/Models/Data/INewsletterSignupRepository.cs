using System;
using System.Linq;

namespace bookofspells.Models
{
    public interface INewsletterSignup
    {
        // Create
        void AddSignup(NewsletterSignup email);
        // Retrieve
        IQueryable<NewsletterSignup> NewsletterSignup { get; }
        NewsletterSignup GetEmail(string email);
        // Update
        void UpdateEmail(string oldAddress, string newAddress);
        // Delete
        void DeleteEmail(string email);
    }
}
