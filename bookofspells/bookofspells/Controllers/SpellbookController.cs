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
        INewsletterSignup signupRepo;
        ISpellRepository spellRepo;

        public SpellbookController(INewsletterSignup n, ISpellRepository s)
        {
            signupRepo = n;
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

        [HttpPost]
        public IActionResult Index(NewsletterSignup n)
        {
            // send to view
            List<Spell> spells = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            ViewBag.Black = spells.Where(s => s.MagicType == "Black").ToList();
            ViewBag.Grey = spells.Where(s => s.MagicType == "Grey").ToList();
            ViewBag.White = spells.Where(s => s.MagicType == "White").ToList();
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }



        public IActionResult CastSpell()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CastSpell(Spell s, NewsletterSignup n)
        {
            if (ModelState.IsValid)
            {
                // save to database & redirect
                if (s.Title != null)
                {
                    spellRepo.AddSpell(s);
                    return Redirect("Enchantment");
                }
                // return to view
                if (n.EmailAddress != null)
                {
                    signupRepo.AddSignup(n);
                    // send to view
                    ViewBag.Spell = s;
                    ViewBag.Registration = n;
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

        [HttpPost]
        public IActionResult Enchantment(int id, NewsletterSignup n)
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
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }
    }
}
