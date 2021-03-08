using System;
using System.ComponentModel.DataAnnotations;

namespace bookofspells.Models
{
    public class Spell
    {
        [Key]
        public int SpellID { get; set; }  // primary key

        [Required(ErrorMessage = "A spell without a name cannot be cast.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Spell name must be 3-60 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "An empty spell cannot be cast.")]
        [StringLength(8000, MinimumLength = 10, ErrorMessage = "Spell must be at least 10 characters.")]
        public string Enchantment { get; set; }

        [Required(ErrorMessage = "Intention must be set.")]
        public string Intention { get; set; }

        [Required(ErrorMessage = "Magic type must be chosen.")]
        public string MagicType { get; set; }

        public AppUser User { get; set; }

        public string Filename { get; set; }
    }
}
