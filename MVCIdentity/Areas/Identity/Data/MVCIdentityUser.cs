using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MVCIdentity.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MVCIdentityUser class
    public class MVCIdentityUser : IdentityUser
    {
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
