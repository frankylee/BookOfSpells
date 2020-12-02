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
        Spell GetTitle(string title);

        // Update

        // Delete
    }
}
