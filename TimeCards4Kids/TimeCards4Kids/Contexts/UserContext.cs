using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TimeCards4Kids.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            :base(options)
        {

        }
    }

    public DbSet<UserLogin> UserLogins { get; set; }
}
