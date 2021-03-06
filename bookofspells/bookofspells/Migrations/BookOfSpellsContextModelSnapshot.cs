﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bookofspells.Models;

namespace bookofspells.Migrations
{
    [DbContext(typeof(BookOfSpellsContext))]
    partial class BookOfSpellsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8",
                            ConcurrencyStamp = "3d7c8ce7-e9e3-4500-8a35-196d59bd922a",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "028c47d8-4962-b826-5af0-e6483b49a0e1",
                            ConcurrencyStamp = "73eb84ea-438d-4636-9f5d-f13bde23f7d2",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "846aef83-932c-a84b-8244-e836cfa9839d",
                            RoleId = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8"
                        },
                        new
                        {
                            UserId = "1111xxxx-xxxx-1111-xxxx-1111xxxx1111",
                            RoleId = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8"
                        },
                        new
                        {
                            UserId = "2222xxxx-2222-xxxx-2222-xxxx2222xxxx",
                            RoleId = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8"
                        },
                        new
                        {
                            UserId = "3333xxxx-xxxx-xxxx-xxxx-xxxxXXXXxxxx",
                            RoleId = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("bookofspells.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "846aef83-932c-a84b-8244-e836cfa9839d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd20364b-99f3-4672-9dc7-ebad04302a1d",
                            Email = "admin@bookofspells.com",
                            EmailConfirmed = false,
                            FirstName = "Muney",
                            LastName = "Eclipse",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEH0LYa8AvY/Y5fd9EIJZlvcBiMCpqQuiF9pcEhOTt+GgH3iFI0GeD5uN82lgd+heRQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0281a7bf-24d6-461a-8ac6-6ed4e7a0f285",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "1111xxxx-xxxx-1111-xxxx-1111xxxx1111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d994173b-0620-4dc5-b7d8-3f585040795e",
                            Email = "raviniablaque@bookofspells.com",
                            EmailConfirmed = false,
                            FirstName = "Ravinia",
                            LastName = "Blaque",
                            LockoutEnabled = false,
                            NormalizedUserName = "RAVINIABLAQUE",
                            PasswordHash = "AQAAAAEAACcQAAAAECmCWYobnfQKcDxAnEd2gdFhKN3pZi/bbn5CfR3V0UgTl9sX7w06GLpGHzeyAxZieg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e8c4c1fd-551a-49f4-91c6-dfc3300ed2f4",
                            TwoFactorEnabled = false,
                            UserName = "raviniablaque"
                        },
                        new
                        {
                            Id = "2222xxxx-2222-xxxx-2222-xxxx2222xxxx",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "dd326370-c336-472e-a2e6-759765e8bf46",
                            Email = "trundae.sythe@bookofspells.com",
                            EmailConfirmed = false,
                            FirstName = "Trundae",
                            LastName = "Sythe",
                            LockoutEnabled = false,
                            NormalizedUserName = "TRUNDAE.SYTHE",
                            PasswordHash = "AQAAAAEAACcQAAAAEMa7SsG6bDMMd8Pq+Rr+0xvmReWHc3AWdgU2Zi44+ofwQv+ORrSlo2if9iwsUhBBmg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "909238df-d3d1-4435-bc2c-175ffa7bb86d",
                            TwoFactorEnabled = false,
                            UserName = "trundae.sythe"
                        },
                        new
                        {
                            Id = "3333xxxx-xxxx-xxxx-xxxx-xxxxXXXXxxxx",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0ea7fcf1-ec9d-4415-bb5e-dd665266067f",
                            Email = "wilowe_shutes@bookofspells.com",
                            EmailConfirmed = false,
                            FirstName = "Wilowe ",
                            LastName = "Shutes",
                            LockoutEnabled = false,
                            NormalizedUserName = "WILOWE",
                            PasswordHash = "AQAAAAEAACcQAAAAEAZWPIo7cS1t8Vr0JhNWmgtk1dpnQrQSbnhuyT8H7MDtDoapIxC1Vu9F/dlHXqBBfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f9842c7f-1e15-4271-9dca-29323c775520",
                            TwoFactorEnabled = false,
                            UserName = "wilowe"
                        });
                });

            modelBuilder.Entity("bookofspells.Models.ContactForm", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Enchantment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(8000);

                    b.Property<string>("Filename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intention")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MagicType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SpellID");

                    b.HasIndex("UserId");

                    b.ToTable("Spell");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("bookofspells.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("bookofspells.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bookofspells.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("bookofspells.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("bookofspells.Models.Spell", b =>
                {
                    b.HasOne("bookofspells.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
