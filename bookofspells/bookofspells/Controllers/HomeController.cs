using System;
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
        public IActionResult Index(Spell s, NewsletterSignup n)
        {
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
            ViewBag.Message = c;
            ViewBag.Registration = n;
            // save to database
            contactRepo.AddMessage(c);
            signupRepo.AddSignup(n);
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(NewsletterSignup n)
        {
            ViewBag.Registration = n;
            // save to database
            signupRepo.AddSignup(n);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
