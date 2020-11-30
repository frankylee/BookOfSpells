using System;
namespace bookofspells.Models
{
    public class Spell
    {
        //public Spell()
        //{
        //    // does default image go here if not specified?
        //    // or does that happen in View if filename == "" ?
        //}


        // Users can create new spells to add to the Spellbook.
        // Image upload is the only optional field.

        public int SpellID { get; }  // primary key
        public string Title { get; set; }
        public string Enchantment { get; set; }
        public string Intention { get; set; }
        public string MagicType { get; set; }
        public User User { get; set; }
        public string Filename { get; set; }
    }
}
