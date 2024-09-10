using Galaxy.GestionPedidos.Comun.DTO.Request.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.GestionPedidos.Comun.DTO.Request;

namespace Galaxy.GestionPedidos.Servicios.Interfaces
{
    public interface IProductoService
    {
        Task<ResponseBaseDto> CreateAsync(ProductoDtoRequest request);
        Task<ResponseBaseDto<ProductoDtoResponse>> RegistrarAsync(ProductoDtoRequest request);
        Task<ResponsePaginacionDto<ListaProductoDtoResponse>> ListarAsync(PaginacionDtoRequest request);
        Task<ResponsePaginacionDto<ListaProductoDtoResponse>> Listar(PaginacionDtoRequest request);
    }
}
