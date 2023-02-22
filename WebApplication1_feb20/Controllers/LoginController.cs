using Microsoft.AspNetCore.Mvc;
using WebApplication1_feb20.Models;

namespace WebApplication1_feb20.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly SampledbContext _databaseContext;
        public LoginController(SampledbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
