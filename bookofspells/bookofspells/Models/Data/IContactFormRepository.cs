using System;
using System.Collections.Generic;
using System.Linq;

namespace bookofspells.Models
{
    public interface IContactFormRepository
    {
        // Create
        void AddMessage(ContactForm message);

        // Retrieve
        IQueryable<ContactForm> ContactForm { get; }
        List<ContactForm> GetByEmail(string email);

        // Update

        // Delete
    }
}
