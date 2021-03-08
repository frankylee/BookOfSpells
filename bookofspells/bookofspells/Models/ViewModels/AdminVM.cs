using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace bookofspells.Models
{
    public class AdminVM
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
