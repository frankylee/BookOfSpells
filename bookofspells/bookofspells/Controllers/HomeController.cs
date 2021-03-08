using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bookofspells.Models;

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


        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactForm c)
        {
            if (ModelState.IsValid)
            {
                // save to database
                if (c.Name != null)
                    contactRepo.AddMessage(c);
                // send to view
                ViewBag.Message = c;
            }
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Search(string search)
        {
            if (ModelState.IsValid)
            {
                List<Spell> results = null;
                // Check if search is empty or whitespace
                if (search != null && search.Trim() != "")
                {
                    // search for user
                    results = (from s in spellRepo.Spell
                               where s.User.UserName.Contains(search)
                               select s)
                               .OrderByDescending(s => s.SpellID)
                               .ToList();
                    // search magic type
                    if (results.Count == 0)
                        results = (from s in spellRepo.Spell
                                   where s.MagicType.Contains(search)
                                   select s)
                                   .OrderByDescending(s => s.SpellID)
                                   .ToList();
                    // search intention
                    if (results.Count == 0)
                        results = (from s in spellRepo.Spell
                                   where s.Intention.Contains(search)
                                   select s).ToList();
                    // search title
                    if (results.Count == 0)
                        results = (from s in spellRepo.Spell
                                   where s.Title.Contains(search)
                                   select s)
                                   .OrderByDescending(s => s.SpellID)
                                   .ToList();
                    // search enchantment
                    if (results.Count == 0)
                        results = (from s in spellRepo.Spell
                                   where s.Enchantment.Contains(search)
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
                // send to view
                ViewBag.Result = results;
            }
            return View();
        }


        [HttpPost]
        public IActionResult Newsletter(NewsletterSignup n)
        {
            if (ModelState.IsValid)
            {
                // save to database
                if (n.EmailAddress != null)
                    signupRepo.AddSignup(n);
                // send to view
                TempData["RegistrationAddress"] = n.EmailAddress;
            }
            // Redirect to returnUrl
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
