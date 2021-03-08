using System;
using System.Linq;
using bookofspells.Controllers;
using bookofspells.Models;
using Xunit;

namespace bookofspellsTests
{
    public class SpellbookControllerTests
    {
        //// instance variables
        //private FakeNewsletterSignupRepository signupRepo;
        //private FakeSpellRepository spellRepo;
        //private SpellbookController controller;
        //private NewsletterSignup email;
        //private Spell spell;


        //// ARRANGE — constructor behaves the same as [SetUp]
        //public SpellbookControllerTests()
        //{
        //    signupRepo = new FakeNewsletterSignupRepository();
        //    spellRepo = new FakeSpellRepository();
        //    controller = new SpellbookController(signupRepo, spellRepo);
        //    email = new NewsletterSignup()
        //    {
        //        EmailAddress = "illuminate@bookofspells.com"
        //    };
        //    spell = new Spell()
        //    {
        //        Title = "Excepteur Sint Occaecat",
        //        Enchantment = "Lorem ipsum dolor sit amet.",
        //        Intention = "Knowledge",
        //        MagicType = "White",
        //        User = new AppUser() { FirstName = "Ravinia", LastName = "Blaque" },
        //        Filename = "xyzy.jpg"
        //    };
        //}


        //[Fact]
        //public void AddNewsletterSignupTest()
        //{
        //    // add email registration
        //    controller.Index(email);
        //    // confirm email was added to repo
        //    NewsletterSignup e = signupRepo.NewsletterSignup.First();
        //    Assert.Equal(email.EmailAddress, e.EmailAddress);
        //}

        //[Fact]
        //public void AddSpellTest() 
        //{
        //    // add new spell
        //    controller.CastSpell(spell, email);
        //    // confirm spell was added to repo
        //    Spell s = spellRepo.Spell.First();
        //    Assert.Equal(spell.Title, s.Title);
        //    Assert.Equal(spell.Enchantment, s.Enchantment);
        //    Assert.Equal(spell.Intention, s.Intention);
        //    Assert.Equal(spell.MagicType, s.MagicType);
        //    Assert.Equal(spell.User.UserName, s.User.UserName);
        //    Assert.Equal(spell.Filename, s.Filename);
        //}

        //[Fact]
        //public void GetSpellTitleTest()
        //{
        //    spellRepo.AddSpell(spell);
        //    // retrieve enchantment view
        //    controller.Enchantment(spell.SpellID);
        //    // confirm enchantment retrieved
        //    Spell s = spellRepo.GetSpellTitle(spell.Title);
        //    Assert.Equal(spell.Title, s.Title);
        //}

        
    }
}
