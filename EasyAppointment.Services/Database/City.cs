using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class City
    {
        public City()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int CityId { get; set; }
        public string? CityName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
