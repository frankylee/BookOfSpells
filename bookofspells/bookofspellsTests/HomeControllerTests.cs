using System;
using System.Linq;
using bookofspells.Controllers;
using bookofspells.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Xunit;

namespace bookofspellsTests
{
    public class HomeControllerTests
    {
        // instance variables
        private FakeContactFormRepository contactRepo;
        private FakeNewsletterSignupRepository signupRepo;
        private FakeSpellRepository spellRepo;
        private HomeController controller;
        private ContactForm message;
        private NewsletterSignup email;
        private Spell spell;


        // ARRANGE — constructor behaves the same as [SetUp]
        public HomeControllerTests()
        {
            contactRepo = new FakeContactFormRepository();
            signupRepo = new FakeNewsletterSignupRepository();
            spellRepo = new FakeSpellRepository();
            controller = new HomeController(new NullLogger<HomeController>(), contactRepo, signupRepo, spellRepo);
            message = new ContactForm()
            {
                Name = "Luminous Nox-Lupin",
                Email = "luminous_nox_lupin@mysteriesofthenox.com",
                Phone = "737-555-9993",
                Message = "Lorem ipsum dolor sit amet."
            };
            email = new NewsletterSignup()
            {
                EmailAddress = "illuminate@bookofspells.com"
            };
            spell = new Spell()
            {
                Title = "Excepteur Sint Occaecat",
                Enchantment = "Lorem ipsum dolor sit amet.",
                Intention = "Knowledge",
                MagicType = "White",
                User = new AppUser() { FirstName = "Ravinia", LastName = "Blaque" },
                Filename = "xyzy.jpg"
            };
            spellRepo.AddSpell(spell);
        }


        [Fact]
        public void AddNewsletterSignupTest()
        {
            // add email registration
            controller.Index(email);
            // confirm email was added to repo
            NewsletterSignup e = signupRepo.NewsletterSignup.First();
            Assert.Equal(email.EmailAddress, e.EmailAddress);
        }

        [Fact]
        public void AddContactFormTest()
        {
            // add new message
            controller.Contact(message, email);
            // confirm message was added to repo
            ContactForm m = contactRepo.ContactForm.First();
            Assert.Equal(message.Name, m.Name);
            Assert.Equal(message.Email, m.Email);
            Assert.Equal(message.Phone, m.Phone);
            Assert.Equal(message.Message, m.Message);
        }

        [Fact]
        public void SearchTest()
        {
            // search
            string search = "Excepteur Sint Occaecat";
            controller.Search(search, email);
            // confirm result fetched
            Spell s = spellRepo.GetSpellTitle(search);
            Console.WriteLine("SPELL: " + s.Title);
            Assert.Equal(search, s.Title);
        }

    }
}
