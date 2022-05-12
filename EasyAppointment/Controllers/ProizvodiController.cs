using EasyAppointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyAppointment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : ControllerBase
    {
        private readonly IProizvodiService _proizvodiService;
        public ProizvodiController(IProizvodiService proizvodiService)
        {
            _proizvodiService = proizvodiService;
        }
        [HttpGet]
        public IEnumerable<Proizvodi> Get(string? naziv, string? sifra)
        {
            return _proizvodiService.Get();
        }
        [HttpGet("{id}")]
        public Proizvodi GetById(int id)
        {
            return _proizvodiService.GetById(id);
        }
    }
}
