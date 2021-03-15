using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace bookofspells.Models
{
    public class BookOfSpellsContext : IdentityDbContext<AppUser>
    {
        public BookOfSpellsContext(DbContextOptions<BookOfSpellsContext> options) : base(options) { }

        // tables
        public DbSet<ContactForm> ContactForm { get; set; }
        public DbSet<NewsletterSignup> NewsletterSignup { get; set; }
        public DbSet<Spell> Spell { get; set; }


        // seed data upon database creation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Seed contact form message
            modelBuilder.Entity<ContactForm>().HasData(
                new ContactForm
                {
                    MessageID = 1,
                    Name = "Luminous Nox-Lupin",
                    Email = "luminous_nox_lupin@mysteriesofthenox.com",
                    Phone = "737-555-9993",
                    Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in."
                }
            );


            // Seed newsletter signup with emails
            modelBuilder.Entity<NewsletterSignup>().HasData(
                new NewsletterSignup
                {
                    EmailID = 1,
                    EmailAddress = "illuminate@bookofspells.com"
                },
                new NewsletterSignup
                {
                    EmailID = 2,
                    EmailAddress = "raviniablaque@bookofspells.com"
                },
                new NewsletterSignup
                {
                    EmailID = 3,
                    EmailAddress = "trundae.sythe@bookofspells.com"
                },
                new NewsletterSignup
                {
                    EmailID = 4,
                    EmailAddress = "wilowe_shutes@bookofspells.com"
                }
            );


            // Seed Identity User Roles: Administrator & User
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8",
                    Name = "Administrator",                       
                    NormalizedName = "ADMINISTRATOR".ToUpper()
                },
                new IdentityRole
                {
                    Id = "028c47d8-4962-b826-5af0-e6483b49a0e1",
                    Name = "User",
                    NormalizedName = "USER".ToUpper()
                }
            );


            // Hash password before seeding user
            var hasher = new PasswordHasher<AppUser>();

            // Seed AppUsers 
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "846aef83-932c-a84b-8244-e836cfa9839d",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN".ToUpper(),
                    FirstName = "Muney",
                    LastName = "Eclipse",
                    Email = "admin@bookofspells.com",
                    PasswordHash = hasher.HashPassword(null, "Secret1!")
                },
                new AppUser
                {
                    Id = "1111xxxx-xxxx-1111-xxxx-1111xxxx1111",
                    UserName = "raviniablaque",
                    NormalizedUserName = "RAVINIABLAQUE".ToUpper(),
                    FirstName = "Ravinia",
                    LastName = "Blaque",
                    Email = "raviniablaque@bookofspells.com",
                    PasswordHash = hasher.HashPassword(null, "Secret1!")
                },
                new AppUser
                {
                    Id = "2222xxxx-2222-xxxx-2222-xxxx2222xxxx",
                    UserName = "trundae.sythe",
                    NormalizedUserName = "trundae.sythe".ToUpper(),
                    FirstName = "Trundae",
                    LastName = "Sythe",
                    Email = "trundae.sythe@bookofspells.com",
                    PasswordHash = hasher.HashPassword(null, "Secret1!")
                },
                new AppUser
                {
                    Id = "3333xxxx-xxxx-xxxx-xxxx-xxxxXXXXxxxx",
                    UserName = "wilowe",
                    NormalizedUserName = "wilowe".ToUpper(),
                    FirstName = "Wilowe ",
                    LastName = "Shutes",
                    Email = "wilowe_shutes@bookofspells.com",
                    PasswordHash = hasher.HashPassword(null, "Secret1!")
                }
            );

            // Seed AppUsers to AspNetUserRoles
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "93b6f9c6-826a-3b54-53ae-e9f8c562fea8",
                    UserId = "846aef83-932c-a84b-8244-e836cfa9839d"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "028c47d8-4962-b826-5af0-e6483b49a0e1",
                    UserId = "1111xxxx-xxxx-1111-xxxx-1111xxxx1111"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "028c47d8-4962-b826-5af0-e6483b49a0e1",
                    UserId = "2222xxxx-2222-xxxx-2222-xxxx2222xxxx"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "028c47d8-4962-b826-5af0-e6483b49a0e1",
                    UserId = "3333xxxx-xxxx-xxxx-xxxx-xxxxXXXXxxxx"
                }
            );
        }
    }
}
