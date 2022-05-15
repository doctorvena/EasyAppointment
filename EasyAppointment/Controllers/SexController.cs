using EasyAppointment.Model;
using EasyAppointment.Services;
using Microsoft.AspNetCore.Mvc;

namespace EasyAppointment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SexController : ControllerBase
    {
        private readonly ISexService _sexService;
        public SexController(ISexService sexService)
        {
            _sexService = sexService;
        }
        [HttpGet]
        public IEnumerable<Sex> Get()
        {
            return _sexService.Get();
        }
    }
}
