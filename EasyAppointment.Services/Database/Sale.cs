using System;
using System.Collections.Generic;

namespace EasyAppointment.Services.Database
{
    public partial class Sale
    {
        public Sale()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        public int SaleId { get; set; }
        public string? SaleType { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
