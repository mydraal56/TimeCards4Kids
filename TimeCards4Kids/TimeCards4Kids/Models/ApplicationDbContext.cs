using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TimeCards4Kids.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}

