using Galaxy.GestionPedidos.AccesoDatos.Contexto;
using Galaxy.GestionPedidos.Comun.DTO.Request;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Entidades;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using System;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.GestionPedidos.Repositorios.Implementaciones;

public class ProductoRepository : RepositoryBase<TbProducto>, IProductoRepository
{
    public ProductoRepository(BdPedidosContext context)
        : base(context)
    {
    }

    public async Task<ResponsePaginacionDto<ListaProductoDtoResponse>> ListarAsync(PaginacionDtoRequest request)
    {
        ResponsePaginacionDto<ListaProductoDtoResponse> respuesta = new ResponsePaginacionDto<ListaProductoDtoResponse>();
        try
        {

            var resultadoClasico = (from item in Context.TbProductos
                                    select new ListaProductoDtoResponse
                                    {
                                        Id = item.Id,
                                        Nombre = item.Nombre,
                                        Descripcion = item.Descripcion,
                                        Categoria = item.IdMaeCategoriaNavigation!.Valor,
                                        Marca = item.IdMaeMarcaNavigation!.Valor
                                    })
                             .Skip((request.NumeroPagina - 1) * request.TotalFilas)
                             .Take(request.TotalFilas)
                             .AsNoTracking()
                             .ToList();

            var total = await Context.TbProductos.CountAsync();

            respuesta.Data = resultadoClasico;
            respuesta.TotalFilas = total;
            respuesta.Message = "Producto registrado exitosamente";

        }
        catch (Exception ex)
        {
            respuesta.Success = false;
            respuesta.Message = ex.Message;
        }
        return respuesta;
    }

}