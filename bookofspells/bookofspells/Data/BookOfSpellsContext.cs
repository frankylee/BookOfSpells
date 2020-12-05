using System;
using bookofspells.Models;
using Microsoft.EntityFrameworkCore;

namespace bookofspells.Data
{
    public class BookOfSpellsContext : DbContext
    {
        public BookOfSpellsContext(DbContextOptions<BookOfSpellsContext> options) : base(options) { }

        // tables
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<NewsletterSignup> NewsletterSignup { get; set; }
        public DbSet<Spell> Spell { get; set; }
        public DbSet<User> User { get; set; }



        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ContactForm>().HasData(
        //        new ContactForm
        //        {
        //            MessageID = 1,
        //            Name = "Luminous Nox-Lupin",
        //            Email = "luminous_nox_lupin@mysteriesofthenox.com",
        //            Phone = "737-555-9993",
        //            Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in."
        //        }
        //    );

        //    modelBuilder.Entity<NewsletterSignup>().HasData(
        //        new NewsletterSignup
        //        {
        //            EmailID = 1,
        //            EmailAddress = "illuminate@bookofspells.com"
        //        },
        //        new NewsletterSignup
        //        {
        //            EmailID = 2,
        //            EmailAddress = "raviniablaque@bookofspells.com"
        //        },
        //        new NewsletterSignup
        //        {
        //            EmailID = 3,
        //            EmailAddress = "trundae.sythe@bookofspells.com"
        //        },
        //        new NewsletterSignup
        //        {
        //            EmailID = 4,
        //            EmailAddress = "wilowe_shutes@bookofspells.com"
        //        }
        //    );

        //    modelBuilder.Entity<User>().HasData(
        //        new User
        //        {
        //            UserID = 1,
        //            Username = "raviniablaque",
        //            FirstName = "Ravinia",
        //            LastName = "Blaque",
        //            EmailAddress = "raviniablaque@bookofspells.com"
        //        },
        //        new User
        //        {
        //            UserID = 2,
        //            Username = "trundae.sythe",
        //            FirstName = "Trundae",
        //            LastName = "Sythe",
        //            EmailAddress = "trundae.sythe@bookofspells.com"
        //        },
        //        new User
        //        {
        //            UserID = 3,
        //            Username = "wilowe",
        //            FirstName = "Wilowe ",
        //            LastName = "Shutes",
        //            EmailAddress = "wilowe_shutes@bookofspells.com"
        //        }
        //    );

        //    modelBuilder.Entity<Spell>().HasData(
        //        new Spell
        //        {
        //            Title = "In Vitae Tempus Elementum",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Protection",
        //            MagicType = "Grey",
        //            User = user1,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        },

        //        new Spell
        //        {
        //            Title = "Excepteur Sint Occaecat",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Wealth",
        //            MagicType = "Black",
        //            User = user2,
        //            Filename = "devil-goat-with-sacred-geometry.png",
        //        },

        //        new Spell
        //        {
        //            Title = "Enim Ad Minim Veniam",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Knowledge",
        //            MagicType = "White",
        //            User = user3,
        //            Filename = "mandala_geometry_sacred_symbol_4242415.png",
        //        },
                
        //        new Spell
        //        {
        //            Title = "Aute Irure Dolor",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Love",
        //            MagicType = "Grey",
        //            User = user3,
        //            Filename = "devil-goat-with-sacred-geometry.png",
        //        },
                
        //        new Spell
        //        {
        //            Title = "Hendrerit Gravida Rutrum",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Protection",
        //            MagicType = "White",
        //            User = user1,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        },
                
        //        new Spell
        //        {
        //            Title = "Nunc Aliquet Bibendum",
        //            Enchantment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Power",
        //            MagicType = "Black",
        //            User = user3,
        //            Filename = "mandala_geometry_sacred_symbol_4242415.png",
        //        }
        //    );

        //}
    }
}
