using Galaxy.GestionPedidos.Comun.DTO.Request;
using Galaxy.GestionPedidos.Comun.DTO.Request.Producto;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Galaxy.GestionPedidos.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galaxy.GestionPedidos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeguridadController : ControllerBase
    {
        private IUsuarioService _service;
        public SeguridadController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet("Usuario/ByUserName/{username}")]
        public async Task<IActionResult> Get(string username)
        {
            var result = await _service.ObtenerColaboradoresPorUsuario(username);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("Usuario/GetPermisos/{username}")]
        public async Task<IActionResult> GetPermisos(string username)
        {
            var result = await _service.ListarPermisos(username);
            return result.Success ? Ok(result) : BadRequest(result);
        }


    }
}
