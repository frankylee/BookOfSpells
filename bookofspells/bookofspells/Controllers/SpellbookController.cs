﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bookofspells.Controllers
{
    public class SpellbookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CastSpell()
        {
            return View();
        }

        public IActionResult Enchantment()
        {
            return View();
        }
    }
}
