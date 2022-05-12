using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Sex
    {
        public Sex()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int SexId { get; set; }
        public string? SexName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
