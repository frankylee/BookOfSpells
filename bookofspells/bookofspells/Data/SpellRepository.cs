using System;
using System.Linq;
using bookofspells.Models;
using Microsoft.EntityFrameworkCore;

namespace bookofspells.Data
{
    public class SpellRepository : ISpellRepository
    {
        // instance variables
        private BookOfSpellsContext context;

        // constructor
        public SpellRepository(BookOfSpellsContext c)
        {
            context = c;
        }

        // interface methods
        public IQueryable<Spell> Spell
        {
            get
            {   // Get all Spell objects in the Spell DBContext
                // and include the User object
                return context.Spell.Include(s => s.User);
            }
        }

        public void AddSpell(Spell spell)
        {
            // store in database
            context.Spell.Add(spell);
            context.SaveChanges();
        }

        public Spell GetTitle(string title)
        {
            // find and return the first spell with matching title
            Spell spell = context.Spell.First(s => s.Title == title);
            return spell;
        }
    }
}
