using System;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
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
