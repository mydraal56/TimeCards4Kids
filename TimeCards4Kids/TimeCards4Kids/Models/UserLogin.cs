using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace TimeCards4Kids.Models
{
    public class UserLogin : IdentityUser
    {
        [Key]
        public int loginId { get; set; }
        public string distinguishedUserName { get; set; }
        public string passwordHash { get; set; }
        public string normalizedUserName { get; set; }
        public int userId { get; set; }
    }
}
