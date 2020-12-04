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
            {
                // Get all Spell objects in the Spell DBContext
                // and include the User object
                return context.Spell.Include(s => s.User);
            }
        }

        public void AddSpell(Spell spell)
        {
            // check filename and swap to generator
            spell.Filename = CheckFilename(spell.Filename);
            // store in database
            context.Spell.Add(spell);
            context.SaveChanges();
        }

        public Spell GetSpellTitle(string title)
        {
            // find and return the first spell with matching title
            Spell spell = context.Spell.Include(s => s.User).FirstOrDefault(s => s.Title == title);
            return spell;
        }


        // Check the img filename and swap to random
        private string CheckFilename(string filename)
        {
            string[] img = {
                "devil-goat-with-sacred-geometry.png",
                "mandala_sacred_ancient_geometry_vector_3732998.png",
                "mandala_geometry_sacred_symbol_4242415.png"
            };

            bool isMatch = false;
            for (int i = 0; i < img.Length; i++)
            {
                if (filename == img[i])
                    return filename;
            }

            if (!isMatch)
            {
                Random gen = new Random();
                int rand = gen.Next();
                if (rand % 3 == 0)
                    filename = img[2];
                else if (rand % 2 == 0)
                    filename = img[0];
                else
                    filename = img[1];
            }
            return filename;
        }
    }
}
