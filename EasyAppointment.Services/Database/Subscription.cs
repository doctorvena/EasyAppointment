using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Subscription
    {
        public int SubscriptionId { get; set; }
        public string? SubscriptionType { get; set; }
        public int? AppUserId { get; set; }
        public DateTime? DateOfSubscription { get; set; }
        public bool? IsActive { get; set; }
        public int? SaleId { get; set; }

        public virtual AppUser? AppUser { get; set; }
        public virtual Sale? Sale { get; set; }
    }
}
