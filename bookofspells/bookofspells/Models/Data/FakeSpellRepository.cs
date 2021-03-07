using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace bookofspells.Models
{
    public class FakeSpellRepository : ISpellRepository
    {
        // instance variables
        private readonly List<Spell> spells = new List<Spell>();


        // cast List object as IQueryable
        public IQueryable<Spell> Spell { get { return spells.AsQueryable(); } }


        public void AddSpell(Spell spell)
        {
            // simulate db primary key
            spell.SpellID = spells.Count;
            spells.Add(spell);
        }

        public Spell GetSpellTitle(string title)
        {
            // find and return the first spell with matching title
            Spell spell = Spell.Include(s => s.User).FirstOrDefault(s => s.Title.Equals(title));
            return spell;
        }
    }
}
