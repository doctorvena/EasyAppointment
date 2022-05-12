using EasyAppointment.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAppointment.Services
{
    public class AppUserService : IAppUserService
    {
        public _170148Context Context { get; set; }
        public AppUserService(_170148Context context)
        {
           Context = context;
        }
        public IEnumerable<AppUser> GetAll()
        {
            return Context.AppUsers?.ToList();
        }
    }
}
