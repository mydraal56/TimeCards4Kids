using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace TimeCards4Kids.Models
{
    public class UserLogin: IdentityUser
    {
        [Key]
        public int userId { get; set; }
        public string distinguishedUserName { get; set; }
        //public string passwordHash { get; set; }
    }
}
