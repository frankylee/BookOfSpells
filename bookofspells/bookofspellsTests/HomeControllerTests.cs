using System;
using System.Linq;
using bookofspells.Controllers;
using bookofspells.Data;
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
                User = new User() { Username = "Ravinia Blaque" },
                Filename = "xyzy.jpg"
            };
        }


        [Fact]
        public void AddNewsletterSignupTest()
        {
            // add email registration
            controller.Index(spell, email);
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

    }
}
