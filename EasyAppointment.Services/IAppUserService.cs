using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAppointment.Services
{
    public interface IAppUserService
    {
        IEnumerable<Database.AppUser> GetAll();
    }
}
