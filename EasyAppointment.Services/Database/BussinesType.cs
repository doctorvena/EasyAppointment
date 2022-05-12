using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class BussinesType
    {
        public BussinesType()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int BussinesTypeId { get; set; }
        public string? BussinesTypeName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}
