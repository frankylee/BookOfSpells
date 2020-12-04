using System;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
{
    public class SeedData
    {
        // Create user objects once and save to context so spells will be
        // associated with the same entity in the database.

        private static readonly User user1 = new User
        {
            Username = "raviniablaque",
            FirstName = "Ravinia",
            LastName = "Blaque",
            EmailAddress = "raviniablaque@bookofspells.com"
        };
        private static readonly User user2 = new User
        {
            Username = "trundae.sythe",
            FirstName = "Trundae",
            LastName = "Sythe",
            EmailAddress = "trundae.sythe@bookofspells.com"
        };
        private static readonly User user3 = new User
        {
            Username = "wilowe",
            FirstName = "Wilowe ",
            LastName = "Shutes",
            EmailAddress = "wilowe_shutes@bookofspells.com"
        };


        public static void Seed(BookOfSpellsContext context)
        {
            if (!context.NewsletterSignup.Any())
            {
                NewsletterSignup email = new NewsletterSignup
                {
                    EmailAddress = "illuminate@bookofspells.com"
                };
                context.NewsletterSignup.Add(email);
                context.SaveChanges();
            }


            if (!context.User.Any())
            {
                context.User.Add(user1);
                context.User.Add(user2);
                context.User.Add(user3);
                context.SaveChanges();
            }


            // NOTE: Indentation are offset for string literal Enchantments.
            if (!context.Spell.Any())
            {
                Spell spell = new Spell
                {
                    Title = "In Vitae Tempus Elementum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.

In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Protection",
                    MagicType = "Grey",
                    User = user1,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
                context.Spell.Add(spell);


                spell = new Spell
                {
                    Title = "Excepteur Sint Occaecat",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas.

Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Wealth",
                    MagicType = "Black",
                    User = user2,
                    Filename = "devil-goat-with-sacred-geometry.png",
                };
                context.Spell.Add(spell);


                spell = new Spell
                {
                    Title = "Enim Ad Minim Veniam",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.

Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Knowledge",
                    MagicType = "White",
                    User = user3,
                    Filename = "mandala_geometry_sacred_symbol_4242415.png",
                };
                context.Spell.Add(spell);

                spell = new Spell
                {
                    Title = "Aute Irure Dolor",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam.

Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Love",
                    MagicType = "Grey",
                    User = user3,
                    Filename = "devil-goat-with-sacred-geometry.png",
                };
                context.Spell.Add(spell);

                spell = new Spell
                {
                    Title = "Hendrerit Gravida Rutrum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.

Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae.

In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Protection",
                    MagicType = "White",
                    User = user1,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
                context.Spell.Add(spell);

                spell = new Spell
                {
                    Title = "Nunc Aliquet Bibendum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Power",
                    MagicType = "Black",
                    User = user3,
                    Filename = "mandala_geometry_sacred_symbol_4242415.png",
                };
                context.Spell.Add(spell);

                // save data
                context.SaveChanges();
            }


            if (!context.ContactForm.Any())
            {
                ContactForm message = new ContactForm
                {
                    Name = "Luminous Nox-Lupin",
                    Email = "luminous_nox_lupin@mysteriesofthenox.com",
                    Phone = "737-555-9993",
                    Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in."
                };
                context.ContactForm.Add(message);
                context.SaveChanges();
            }
        }
    }
}
