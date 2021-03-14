using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bookofspells.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace bookofspells.Controllers
{
    public class SpellbookController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        ISpellRepository spellRepo;

        public SpellbookController(UserManager<AppUser> userMngr, SignInManager<AppUser> signInMngr, ISpellRepository s)
        {
            userManager = userMngr;
            signInManager = signInMngr;
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


        [Authorize]
        public IActionResult CastSpell()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CastSpell(Spell s)
        {
            if (ModelState.IsValid)
            {
                // Add logged in user to the model
                // Note: this null-check allows unit tests to pass with hardcoded user
                if (s.User == null)
                    s.User = await userManager.GetUserAsync(User);
                // Add spell to the database
                spellRepo.AddSpell(s);
                // Redirect user to view their cast spell
                return Redirect("Enchantment"); 
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
