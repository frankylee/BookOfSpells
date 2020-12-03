using System;
using System.Collections.Generic;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
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
