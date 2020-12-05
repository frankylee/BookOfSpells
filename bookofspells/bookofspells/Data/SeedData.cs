using System;
using System.Collections.Generic;
using System.Linq;
using bookofspells.Models;

namespace bookofspells.Data
{
    public class SeedData
    {

        public static void Seed(BookOfSpellsContext context)
        {
            // populate data for startup seed
            if (!context.User.Any())
            {
                User u = new User
                {
                    Username = "raviniablaque",
                    FirstName = "Ravinia",
                    LastName = "Blaque",
                    EmailAddress = "raviniablaque@bookofspells.com"
                };
                context.User.Add(u);

                u = new User
                {
                    Username = "trundae.sythe",
                    FirstName = "Trundae",
                    LastName = "Sythe",
                    EmailAddress = "trundae.sythe@bookofspells.com"
                };
                context.User.Add(u);

                u = new User
                {
                    Username = "wilowe",
                    FirstName = "Wilowe ",
                    LastName = "Shutes",
                    EmailAddress = "wilowe_shutes@bookofspells.com"
                };
                context.User.Add(u);
                context.SaveChanges();
            }

            if (!context.Spell.Any())
            {
                Spell s = new Spell
                {
                    SpellID = 1,
                    Title = "In Vitae Tempus Elementum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.

                        In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas.

                        Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Protection",
                    MagicType = "Grey",
                    UserID = 1,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 2,
                    Title = "Excepteur Sint Occaecat",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in.

                        Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Wealth",
                    MagicType = "Black",
                    UserID = 2,
                    Filename = "devil-goat-with-sacred-geometry.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 3,
                    Title = "Enim Ad Minim Veniam",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Knowledge",
                    MagicType = "White",
                    UserID = 3,
                    Filename = "mandala_geometry_sacred_symbol_4242415.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 4,
                    Title = "Aute Irure Dolor",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit.

                        In voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

                        Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Love",
                    MagicType = "Grey",
                    UserID = 3,
                    Filename = "devil-goat-with-sacred-geometry.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 5,
                    Title = "Hendrerit Gravida Rutrum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore.

                        Eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis.

                        Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae.

                        In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Protection",
                    MagicType = "White",
                    UserID = 1,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 6,
                    Title = "Nunc Aliquet Bibendum",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                    Intention = "Power",
                    MagicType = "Black",
                    UserID = 2,
                    Filename = "mandala_geometry_sacred_symbol_4242415.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 7,
                    Title = "Magna Exercitation",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    Intention = "Wealth",
                    MagicType = "Grey",
                    UserID = 3,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 8,
                    Title = "Laboris Nisi ut Aliquip",
                    Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    Intention = "Knowledge",
                    MagicType = "White",
                    UserID = 2,
                    Filename = "devil-goat-with-sacred-geometry.png",
                };
                context.Spell.Add(s);

                s = new Spell
                {
                    SpellID = 9,
                    Title = "Fringilla est Ullamcorper",
                    Enchantment = @"Diam maecenas ultricies mi eget mauris pharetra et. Mi in nulla posuere sollicitudin aliquam ultrices sagittis. Purus non enim praesent elementum facilisis.

                        Pellentesque pulvinar pellentesque habitant morbi tristique senectus. Nunc lobortis mattis aliquam faucibus purus in. Amet volutpat consequat mauris nunc.

                        In aliquam sem fringilla ut morbi. Mus mauris vitae ultricies leo integer malesuada nunc. Nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque. Eget mi proin sed libero enim. Porta non pulvinar neque laoreet suspendisse.",
                    Intention = "Protection",
                    MagicType = "Black",
                    UserID = 1,
                    Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                };
            }
        }



        //// Create user objects once so spells will be associated with the
        //// same entity in the database.
        //private static User user1 = new User
        //{
        //    UserID = 1,
        //    Username = "raviniablaque",
        //    FirstName = "Ravinia",
        //    LastName = "Blaque",
        //    EmailAddress = "raviniablaque@bookofspells.com"
        //};
        //private static User user2 = new User
        //{
        //    UserID = 2,
        //    Username = "trundae.sythe",
        //    FirstName = "Trundae",
        //    LastName = "Sythe",
        //    EmailAddress = "trundae.sythe@bookofspells.com"
        //};
        //private static User user3 = new User
        //{
        //    UserID = 3,
        //    Username = "wilowe",
        //    FirstName = "Wilowe ",
        //    LastName = "Shutes",
        //    EmailAddress = "wilowe_shutes@bookofspells.com"
        //};



        //public static void Seed(BookOfSpellsContext context)
        //{
        //    // populate data for startup seed
        //    GenerateContactForm(context);
        //    GenerateNewsletterSignup(context);
        //    GenerateUser(context);
        //    GenerateSpell(context);
        //}



        //private static void GenerateContactForm(BookOfSpellsContext context)
        //{
        //    ContactForm message = new ContactForm
        //    {
        //        MessageID = 1,
        //        Name = "Luminous Nox-Lupin",
        //        Email = "luminous_nox_lupin@mysteriesofthenox.com",
        //        Phone = "737-555-9993",
        //        Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in."
        //    };
        //    //if (context.ContactForm.Find(message.MessageID).MessageID == 0)
        //    //    context.ContactForm.Add(message);
        //    //else
        //    //    context.ContactForm.Update(message);

        //    context.ContactForm.Update(message);
        //    context.SaveChanges();
        //}

        //private static void GenerateNewsletterSignup(BookOfSpellsContext context)
        //{
        //    List<NewsletterSignup> emails = new List<NewsletterSignup>()
        //    {
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
        //    };
        //    //emails.ForEach(e =>
        //    //{
        //    //    if (context.NewsletterSignup.Find(e.EmailID).EmailID == 0)
        //    //        context.NewsletterSignup.Add(e);
        //    //    else
        //    //        context.NewsletterSignup.Update(e);
        //    //});

        //    emails.ForEach(e => context.NewsletterSignup.Update(e));
        //    context.SaveChanges();
        //}


        //private static void GenerateUser(BookOfSpellsContext context)
        //{
        //    List<User> users = new List<User>()
        //    {
        //        user1,
        //        user2,
        //        user3
        //    };
        //    //users.ForEach(u =>
        //    //{
        //    //    if (context.User.Find(u.UserID).UserID == 0)
        //    //        context.User.Add(u);
        //    //    else
        //    //        context.User.Update(u);
        //    //});

        //    users.ForEach(u => context.User.Update(u));
        //    context.SaveChanges();
        //}


        //private static void GenerateSpell(BookOfSpellsContext context)
        //{
        //    List<Spell> spells = new List<Spell>()
        //    {
        //        new Spell
        //        {
        //            SpellID = 1,
        //            Title = "In Vitae Tempus Elementum",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.

        //                In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas.

        //                Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Protection",
        //            MagicType = "Grey",
        //            User = user1,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 2,
        //            Title = "Excepteur Sint Occaecat",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

        //                Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in.

        //                Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Wealth",
        //            MagicType = "Black",
        //            User = user2,
        //            Filename = "devil-goat-with-sacred-geometry.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 3,
        //            Title = "Enim Ad Minim Veniam",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

        //                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

        //                Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Knowledge",
        //            MagicType = "White",
        //            User = user3,
        //            Filename = "mandala_geometry_sacred_symbol_4242415.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 4,
        //            Title = "Aute Irure Dolor",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit.

        //                In voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

        //                Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Love",
        //            MagicType = "Grey",
        //            User = user3,
        //            Filename = "devil-goat-with-sacred-geometry.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 5,
        //            Title = "Hendrerit Gravida Rutrum",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore.

        //                Eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis.

        //                Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae.

        //                In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Protection",
        //            MagicType = "White",
        //            User = user1,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 6,
        //            Title = "Nunc Aliquet Bibendum",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

        //                Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
        //            Intention = "Power",
        //            MagicType = "Black",
        //            User = user2,
        //            Filename = "mandala_geometry_sacred_symbol_4242415.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 7,
        //            Title = "Magna Exercitation",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

        //                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

        //                Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        //            Intention = "Wealth",
        //            MagicType = "Grey",
        //            User = user2,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 8,
        //            Title = "Laboris Nisi ut Aliquip",
        //            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

        //                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

        //                Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
        //            Intention = "Knowledge",
        //            MagicType = "White",
        //            User = user2,
        //            Filename = "devil-goat-with-sacred-geometry.png",
        //        },

        //        new Spell
        //        {
        //            SpellID = 9,
        //            Title = "Fringilla est Ullamcorper",
        //            Enchantment = @"Diam maecenas ultricies mi eget mauris pharetra et. Mi in nulla posuere sollicitudin aliquam ultrices sagittis. Purus non enim praesent elementum facilisis.

        //                Pellentesque pulvinar pellentesque habitant morbi tristique senectus. Nunc lobortis mattis aliquam faucibus purus in. Amet volutpat consequat mauris nunc.

        //                In aliquam sem fringilla ut morbi. Mus mauris vitae ultricies leo integer malesuada nunc. Nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque. Eget mi proin sed libero enim. Porta non pulvinar neque laoreet suspendisse.",
        //        Intention = "Protection",
        //            MagicType = "Black",
        //            User = user1,
        //            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
        //        }
        //    };

        //    //spells.ForEach(s =>
        //    //{
        //    //    if (context.Spell.Find(s.SpellID).SpellID == 0)
        //    //        context.Spell.Add(s);
        //    //    else
        //    //        context.Spell.Update(s);
        //    //});

        //    spells.ForEach(s => context.Spell.Update(s));
        //    context.SaveChanges();
        //}
    }
}
