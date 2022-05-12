using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Country
    {
        public Country()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int CountryId { get; set; }
        public string? CountryName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
