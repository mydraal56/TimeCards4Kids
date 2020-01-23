using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeCards4Kids.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TimeCards4Kids.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        {

        }
       // public DbSet<UserLogin> UserLogins { get; set; }

        public DbSet<IdentityUser> identityUsers { get; set; }

        public DbSet<IdentityUserClaim<string>> IdentityUserClaim { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserClaim<string>>().HasKey(p => new { p.Id });

        }
    }


}
