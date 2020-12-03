﻿using System;
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
        INewsletterSignup signupRepo;
        ISpellRepository spellRepo;

        public SpellbookController(INewsletterSignup n, ISpellRepository s)
        {
            signupRepo = n;
            spellRepo = s;
        }


        public IActionResult Index()
        {
            List<Spell> spells = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            ViewBag.Black = spells.Where(s => s.MagicType == "Black").ToList();
            ViewBag.Grey = spells.Where(s => s.MagicType == "Grey").ToList();
            ViewBag.White = spells.Where(s => s.MagicType == "White").ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(NewsletterSignup n)
        {
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
            ViewBag.Spell = s;
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            spellRepo.AddSpell(s);
            return Redirect("Enchantment");
        }



        public IActionResult Enchantment(string title)
        {
            Spell s;
            // if no title is passed, display most recently created spell
            if (title == null || title == "")
                s = spellRepo.Spell.ToList().Last();
            else
                s = spellRepo.GetSpellTitle(title);
            ViewBag.Spell = s;
            return View();
        }

        [HttpPost]
        public IActionResult Enchantment(string title, NewsletterSignup n)
        {
            Spell s;
            // if no title is passed, display most recently created spell
            if (title == null || title == "")
                s = spellRepo.Spell.ToList().Last();
            else
                s = spellRepo.GetSpellTitle(title);
            ViewBag.Spell = s;
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }
    }
}
