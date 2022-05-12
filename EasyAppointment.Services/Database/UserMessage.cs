using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class UserMessage
    {
        public int? MessageId { get; set; }
        public int? AppUserId { get; set; }
    }
}
