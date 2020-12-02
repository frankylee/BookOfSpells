using System;
using bookofspells.Models;
using Microsoft.EntityFrameworkCore;

namespace bookofspells.Data
{
    public class BookOfSpellsContext : DbContext
    {
        public BookOfSpellsContext(DbContextOptions<BookOfSpellsContext> options) : base(options) { }

        // tables
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<NewsletterSignup> NewsletterSignup { get; set; }
        public DbSet<Spell> Spell { get; set; }
        public DbSet<User> User { get; set; }
    }
}
