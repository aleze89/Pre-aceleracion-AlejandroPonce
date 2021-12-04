using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ChallengeDisney.Models
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
    }
}
