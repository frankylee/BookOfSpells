using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class Spell
    {
        [Key]
        public int SpellID { get; set; }  // primary key
        public string Title { get; set; }
        public string Enchantment { get; set; }
        public string Intention { get; set; }
        public string MagicType { get; set; }
        public User User { get; set; }
        public string Filename { get; set; }
    }
}
