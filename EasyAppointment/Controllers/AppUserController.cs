using EasyAppointment.Services;
using EasyAppointment.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace EasyAppointment.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _AppUserService;
        public AppUserController(IAppUserService proizvodiService)
        {
            _AppUserService = proizvodiService;
        }
        [HttpGet]
        public IEnumerable<AppUser> Get(string? naziv, string? sifra)
        {
            return _AppUserService.GetAll();
        }
        [HttpGet("{id}")]
        public AppUser GetById(int id)
        {
            //return _AppUserService.GetById(id);
            return null;
        }

    }
}
