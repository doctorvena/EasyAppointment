using EasyAppointment.Model;
using EasyAppointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyAppointment.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;
        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        [HttpGet]
        public IEnumerable<AppUser> Get()
        {
            return _appUserService.Get();
        }
    }
}
