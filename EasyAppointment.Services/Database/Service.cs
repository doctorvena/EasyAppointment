using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Service
    {
        public Service()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int ServiceId { get; set; }
        public string? ServiceName { get; set; }
        public string? Price { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
