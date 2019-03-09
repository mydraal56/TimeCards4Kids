using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeCards4Kids.Models
{
    public class ApplicationUser 
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int relativeID { get; set; }
        public bool child { get; set; }

    }
}
