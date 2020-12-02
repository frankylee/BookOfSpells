using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bookofspells.Models;
using bookofspells.Data;

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
            List<Spell> spells = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            //ViewBag.Spell = spells;
            ViewBag.Black = spells.Where(s => s.MagicType == "Black").ToList();
            ViewBag.Grey = spells.Where(s => s.MagicType == "Grey").ToList();
            ViewBag.White = spells.Where(s => s.MagicType == "White").ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(NewsletterSignup n)
        {
            ViewBag.Registration = n;
            return View();
        }



        public IActionResult CastSpell()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CastSpell(Spell s, NewsletterSignup n)
        {
            ViewBag.Spell = s;
            ViewBag.Registration = n;
            // store in database
            spellRepo.AddSpell(s);
            return Redirect("Enchantment");
        }



        public IActionResult Enchantment()
        {
            Spell spell = spellRepo.Spell.Last();
            ViewBag.Spell = spell;
            return View();
        }

        [HttpPost]
        public IActionResult Enchantment(NewsletterSignup n)
        {
            ViewBag.Registration = n;
            return View();
        }
    }
}
