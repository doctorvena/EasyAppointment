using AutoMapper;
using EasyAppointment.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAppointment.Services
{
    public class SexService : ISexService
    {
        public _170148Context Context { get; set; }
        public IMapper Mapper { get; set; }
        public SexService(_170148Context context, IMapper mapper)
        {
            Context = context;
            Mapper = mapper;
        }
        public IEnumerable<Model.Sex> Get()
        {
            var entity = Context.Set<Database.Sex>().ToList();

            //NOTE: elaborate IEnumerable vs IList
            return Mapper.Map<IList<Model.Sex>>(entity);
        }

        public Model.Sex GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
