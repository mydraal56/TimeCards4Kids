using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimeCards4Kids.Models
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options)
            :base(options)
        { }

        public DbSet<ApplicationUser> AppUser { get; set; }
        public DbSet<UserLogin> UserLogin { get; set; }
    }


}
