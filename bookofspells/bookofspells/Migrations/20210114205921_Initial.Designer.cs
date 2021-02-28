﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookofspells.Data;

namespace bookofspells.Migrations
{
    [DbContext(typeof(BookOfSpellsContext))]
    [Migration("20210114205921_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("bookofspells.Models.ContactForm", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(254);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(8000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageID");

                    b.ToTable("ContactForm");

                    b.HasData(
                        new
                        {
                            MessageID = 1,
                            Email = "luminous_nox_lupin@mysteriesofthenox.com",
                            Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.",
                            Name = "Luminous Nox-Lupin",
                            Phone = "737-555-9993"
                        });
                });

            modelBuilder.Entity("bookofspells.Models.NewsletterSignup", b =>
                {
                    b.Property<int>("EmailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("EmailID");

                    b.ToTable("NewsletterSignup");

                    b.HasData(
                        new
                        {
                            EmailID = 1,
                            EmailAddress = "illuminate@bookofspells.com"
                        },
                        new
                        {
                            EmailID = 2,
                            EmailAddress = "raviniablaque@bookofspells.com"
                        },
                        new
                        {
                            EmailID = 3,
                            EmailAddress = "trundae.sythe@bookofspells.com"
                        },
                        new
                        {
                            EmailID = 4,
                            EmailAddress = "wilowe_shutes@bookofspells.com"
                        });
                });

            modelBuilder.Entity("bookofspells.Models.Spell", b =>
                {
                    b.Property<int>("SpellID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Enchantment")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(8000);

                    b.Property<string>("Filename")
                        .HasColumnType("TEXT");

                    b.Property<string>("Intention")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MagicType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SpellID");

                    b.HasIndex("UserID");

                    b.ToTable("Spell");

                    b.HasData(
                        new
                        {
                            SpellID = 1,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.

                        In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas.

                        Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                            Intention = "Protection",
                            MagicType = "Grey",
                            Title = "In Vitae Tempus Elementum",
                            UserID = 1
                        },
                        new
                        {
                            SpellID = 2,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in.

                        Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "devil-goat-with-sacred-geometry.png",
                            Intention = "Wealth",
                            MagicType = "Black",
                            Title = "Excepteur Sint Occaecat",
                            UserID = 2
                        },
                        new
                        {
                            SpellID = 3,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "mandala_geometry_sacred_symbol_4242415.png",
                            Intention = "Knowledge",
                            MagicType = "White",
                            Title = "Enim Ad Minim Veniam",
                            UserID = 3
                        },
                        new
                        {
                            SpellID = 4,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit.

                        In voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

                        Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "devil-goat-with-sacred-geometry.png",
                            Intention = "Love",
                            MagicType = "Grey",
                            Title = "Aute Irure Dolor",
                            UserID = 3
                        },
                        new
                        {
                            SpellID = 5,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore.

                        Eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis.

                        Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae.

                        In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                            Intention = "Protection",
                            MagicType = "White",
                            Title = "Hendrerit Gravida Rutrum",
                            UserID = 1
                        },
                        new
                        {
                            SpellID = 6,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.",
                            Filename = "mandala_geometry_sacred_symbol_4242415.png",
                            Intention = "Power",
                            MagicType = "Black",
                            Title = "Nunc Aliquet Bibendum",
                            UserID = 2
                        },
                        new
                        {
                            SpellID = 7,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                            Intention = "Wealth",
                            MagicType = "Grey",
                            Title = "Magna Exercitation",
                            UserID = 3
                        },
                        new
                        {
                            SpellID = 8,
                            Enchantment = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                            Filename = "devil-goat-with-sacred-geometry.png",
                            Intention = "Knowledge",
                            MagicType = "White",
                            Title = "Laboris Nisi ut Aliquip",
                            UserID = 2
                        },
                        new
                        {
                            SpellID = 9,
                            Enchantment = @"Diam maecenas ultricies mi eget mauris pharetra et. Mi in nulla posuere sollicitudin aliquam ultrices sagittis. Purus non enim praesent elementum facilisis.

                        Pellentesque pulvinar pellentesque habitant morbi tristique senectus. Nunc lobortis mattis aliquam faucibus purus in. Amet volutpat consequat mauris nunc.

                        In aliquam sem fringilla ut morbi. Mus mauris vitae ultricies leo integer malesuada nunc. Nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque. Eget mi proin sed libero enim. Porta non pulvinar neque laoreet suspendisse.",
                            Filename = "mandala_sacred_ancient_geometry_vector_3732998.png",
                            Intention = "Protection",
                            MagicType = "Black",
                            Title = "Fringilla est Ullamcorper",
                            UserID = 1
                        });
                });

            modelBuilder.Entity("bookofspells.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT")
                        .HasMaxLength(254);

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            EmailAddress = "raviniablaque@bookofspells.com",
                            FirstName = "Ravinia",
                            LastName = "Blaque",
                            Username = "raviniablaque"
                        },
                        new
                        {
                            UserID = 2,
                            EmailAddress = "trundae.sythe@bookofspells.com",
                            FirstName = "Trundae",
                            LastName = "Sythe",
                            Username = "trundae.sythe"
                        },
                        new
                        {
                            UserID = 3,
                            EmailAddress = "wilowe_shutes@bookofspells.com",
                            FirstName = "Wilowe ",
                            LastName = "Shutes",
                            Username = "wilowe"
                        });
                });

            modelBuilder.Entity("bookofspells.Models.Spell", b =>
                {
                    b.HasOne("bookofspells.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
