using System;
using System.Linq;

namespace bookofspells.Models
{
    public interface ISpellRepository
    {
        // Create
        void AddSpell(Spell spell);

        // Retrieve
        IQueryable<Spell> Spell { get; }
        Spell GetSpellTitle(string title);

        // Update

        // Delete
    }
}
