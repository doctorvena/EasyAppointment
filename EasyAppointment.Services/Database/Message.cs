using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public string? MessageContent { get; set; }
    }
}
