using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class ReportedUser
    {
        public int ReportedUserId { get; set; }
        public string? ReportedUserReason { get; set; }
        public int? AppUserId { get; set; }

        public virtual AppUser? AppUser { get; set; }
    }
}
