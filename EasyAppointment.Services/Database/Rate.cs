using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Rate
    {
        public Rate()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int RateId { get; set; }
        public string? RateName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
