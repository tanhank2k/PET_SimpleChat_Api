using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_Chat_API_Core.Model
{
    public class AppUser: IdentityUser<Guid>
    {
        public string FullName { set; get; }

        public string Address { set; get; }

        public DateTime? Birthday { set; get; }
    }
}
