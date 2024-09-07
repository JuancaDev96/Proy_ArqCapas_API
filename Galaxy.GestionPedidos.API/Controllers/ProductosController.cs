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
    public class ProductosController : ControllerBase
    {
        private IProductoService _productoService;
        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]PaginacionDtoRequest request)
        {
            var result = await _productoService.ListarAsync(request);

            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductoDtoRequest request)
        {
            var result = await _productoService.RegistrarAsync(request);

            return result.Success ? Ok(result) : BadRequest(result);
        }

    }
}
