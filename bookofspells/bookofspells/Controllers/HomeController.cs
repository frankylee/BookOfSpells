﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bookofspells.Models;
using bookofspells.Data;

namespace bookofspells.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IContactFormRepository contactRepo;
        INewsletterSignup signupRepo;
        ISpellRepository spellRepo;

        public HomeController(ILogger<HomeController> logger, IContactFormRepository c, INewsletterSignup n, ISpellRepository s)
        {
            _logger = logger;
            contactRepo = c;
            signupRepo = n;
            spellRepo = s;
        }

        public IActionResult Index()
        {
            List<Spell> s = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            ViewBag.Spell = s;
            return View();
        }

        [HttpPost]
        public IActionResult Index(NewsletterSignup n)
        {
            List<Spell> s = spellRepo.Spell.OrderByDescending(s => s.SpellID).ToList();
            // send to view
            ViewBag.Spell = s;
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm c, NewsletterSignup n)
        {
            // save to database
            if (c.Name != null)
                contactRepo.AddMessage(c);
            if (n.EmailAddress != null)
                signupRepo.AddSignup(n);
            // send to view
            ViewBag.Message = c;
            ViewBag.Registration = n;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(NewsletterSignup n)
        {
            // send to view
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }


        [HttpPost]
        public IActionResult Search(string search, NewsletterSignup n)
        {
            List<Spell> results = null;
            // search database
            if (search != null)
            {
                // convert to lowercase for reliability
                search = search.ToLower();
                // search for user
                results = (from s in spellRepo.Spell
                           where s.User.Username.ToLower().Contains(search)
                           select s)
                           .OrderByDescending(s => s.SpellID)
                           .ToList();
                // search magic type
                if (results.Count == 0)
                    results = (from s in spellRepo.Spell
                               where s.MagicType.ToLower().Contains(search)
                               select s)
                               .OrderByDescending(s => s.SpellID)
                               .ToList();
                // search intention
                if (results.Count == 0)
                    results = (from s in spellRepo.Spell
                               where s.Intention.ToLower().Contains(search)
                               select s).ToList();
                // search title
                if (results.Count == 0)
                    results = (from s in spellRepo.Spell
                               where s.Title.ToLower().Contains(search)
                               select s)
                               .OrderByDescending(s => s.SpellID)
                               .ToList();
                // search enchantment
                if (results.Count == 0)
                    results = (from s in spellRepo.Spell
                               where s.Enchantment.ToLower().Contains(search)
                               select s)
                               .OrderByDescending(s => s.SpellID)
                               .ToList();
                int num = results.Count == 0 ? 0 : results.Count;
                ViewBag.Message = "Your search for " + search + " yielded " + num + " results.";
            }
            else
            {
                ViewBag.Message = "You did not enter a valid search. Please try again.";
            }
            if (n.EmailAddress != null)
                signupRepo.AddSignup(n);
            // send to view
            ViewBag.Result = results;
            ViewBag.Registration = n;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
