using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


using PruebaSD.Negocio;
using PruebaSD.Entidades;

namespace PruebaSD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            _service = new UsuarioService(connectionString);
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return Ok(_service.ListarUsuarios());
        }
    }
}
