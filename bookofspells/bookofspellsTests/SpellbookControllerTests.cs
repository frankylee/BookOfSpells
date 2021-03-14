using System;
using System.Linq;
using bookofspells.Controllers;
using bookofspells.Models;
using Microsoft.AspNetCore.Identity;
using Xunit;

namespace bookofspellsTests
{
    public class SpellbookControllerTests
    {
        // instance variables
        private FakeSpellRepository spellRepo;
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private SpellbookController controller;
        private Spell spell;


        // ARRANGE — constructor behaves the same as [SetUp]
        public SpellbookControllerTests()
        {
            spellRepo = new FakeSpellRepository();
            controller = new SpellbookController(userManager, signInManager, spellRepo);
            spell = new Spell()
            {
                Title = "Excepteur Sint Occaecat",
                Enchantment = "Lorem ipsum dolor sit amet.",
                Intention = "Knowledge",
                MagicType = "White",
                User = new AppUser() {
                    UserName = "raviniablaque",
                    FirstName = "Ravinia",
                    LastName = "Blaque"
                },
                Filename = "xyzy.jpg"
            };
        }

        [Fact]
        public async void CastSpellTest()
        {
            // add new spell
            await controller.CastSpell(spell);
            // confirm spell was added to repo
            Spell s = spellRepo.Spell.First();
            Assert.Equal(spell.Title, s.Title);
            Assert.Equal(spell.Enchantment, s.Enchantment);
            Assert.Equal(spell.Intention, s.Intention);
            Assert.Equal(spell.MagicType, s.MagicType);
            Assert.Equal(spell.User.UserName, s.User.UserName);
            Assert.Equal(spell.Filename, s.Filename);
        }

        [Fact]
        public void GetSpellTitleTest()
        {
            spellRepo.AddSpell(spell);
            // retrieve enchantment view
            controller.Enchantment(spell.SpellID);
            // confirm enchantment retrieved
            Spell s = spellRepo.GetSpellTitle(spell.Title);
            Assert.Equal(spell.Title, s.Title);
        }
    }
}
