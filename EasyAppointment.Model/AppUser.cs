using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAppointment.Model
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? SexId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? SuccessfulAppointments { get; set; }
        public int? FailedAppointments { get; set; }
        public int? UserRoleId { get; set; }
        public int? RateId { get; set; }
        public int? BussinesTypeId { get; set; }

        //public virtual BussinesType? BussinesType { get; set; }
        //public virtual City? City { get; set; }
        //public virtual Country? Country { get; set; }
        //public virtual Rate? Rate { get; set; }
        //public virtual Sex? Sex { get; set; }
        //public virtual ICollection<Appointment> Appointments { get; set; }
        //public virtual ICollection<ReportedUser> ReportedUsers { get; set; }
        //public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
