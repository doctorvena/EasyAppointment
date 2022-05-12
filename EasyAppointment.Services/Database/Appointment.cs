using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int? AppUserId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? DateTimeOfAppointmnet { get; set; }
        public DateTime? DateTimeOfAppointmentCreation { get; set; }
        public string? Reason { get; set; }
        public bool? Urgent { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsOnWait { get; set; }

        public virtual AppUser? AppUser { get; set; }
        public virtual Service? Service { get; set; }
    }
}
