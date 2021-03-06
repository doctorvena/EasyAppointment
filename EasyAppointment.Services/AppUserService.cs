using AutoMapper;
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
        public IMapper Mapper { get; set; }
        public AppUserService(_170148Context context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        public IEnumerable<Model.AppUser> Get()
        {
            var entity = Context.Set<Database.AppUser>().ToList();

            //NOTE: elaborate IEnumerable vs IList
            return Mapper.Map<IList<Model.AppUser>>(entity);
        }

        public Model.AppUser GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
