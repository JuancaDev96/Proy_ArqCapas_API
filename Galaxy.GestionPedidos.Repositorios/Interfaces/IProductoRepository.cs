using Galaxy.GestionPedidos.Comun.DTO.Request;
using Galaxy.GestionPedidos.Comun.DTO.Request.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Entidades;

namespace Galaxy.GestionPedidos.Repositorios.Interfaces;

public interface IProductoRepository : IRepositoryBase<TbProducto>
{
    Task<ResponsePaginacionDto<ListaProductoDtoResponse>> ListarAsync(PaginacionDtoRequest request);
}