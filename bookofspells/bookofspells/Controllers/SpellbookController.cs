using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bookofspells.Models;

namespace bookofspells.Controllers
{
    public class SpellbookController : Controller
    {
        ISpellRepository spellRepo;

        public SpellbookController(ISpellRepository s)
        {
            spellRepo = s;
        }


        public IActionResult Index()
        {
            // send to view
            List<Spell> spells = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            ViewBag.Black = spells.Where(s => s.MagicType == "Black").ToList();
            ViewBag.Grey = spells.Where(s => s.MagicType == "Grey").ToList();
            ViewBag.White = spells.Where(s => s.MagicType == "White").ToList();
            return View();
        }


        public IActionResult CastSpell()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CastSpell(Spell s)
        {
            if (ModelState.IsValid)
            {
                // save to database & redirect
                if (s.Title != null)
                {
                    spellRepo.AddSpell(s);
                    return LocalRedirect("Enchantment");  // changed from Redirect("Enchantment")
                }
            }
            return View();
        }


        public IActionResult Enchantment(int id)
        {
            Spell spell;
            // if no id is passed, display most recently created spell
            if (id == 0)
                spell = spellRepo.Spell.ToList().Last();
            else
                spell = (from s in spellRepo.Spell
                         where s.SpellID.Equals(id)
                         select s).FirstOrDefault();
            // send to view
            ViewBag.Spell = spell;
            return View();
        }
    }
}
