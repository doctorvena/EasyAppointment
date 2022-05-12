using EasyAppointment.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyAppointment.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public _170148Context Context;
        public ProizvodiService(_170148Context context)
        {
            Context = context;
        }
        public List<Proizvodi> proizvodiList = new List<Proizvodi> { new Proizvodi() { Id = 1, Naziv = "Laptop" }, new Proizvodi { Id = 2, Naziv = "Mis" }};
        public IEnumerable<Proizvodi> Get()
        {
            var item = Context.Sexes.ToList();
            proizvodiList.Add(new Proizvodi { Id = 3, Naziv = "test01" });
            return proizvodiList;
        }
        public Proizvodi GetById(int id)
        {
            return proizvodiList.FirstOrDefault(x => x.Id == id);
        }
    }
}
