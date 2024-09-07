using Galaxy.GestionPedidos.Comun.DTO.Request;
using Galaxy.GestionPedidos.Comun.DTO.Request.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Entidades;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Galaxy.GestionPedidos.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Servicios.Implementaciones
{
    public class ProductoService : IProductoService
    {
        private IProductoRepository _productoRepository;
        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<ResponseBaseDto<ProductoDtoResponse>> RegistrarAsync(ProductoDtoRequest request)
        {
            ResponseBaseDto<ProductoDtoResponse> respuesta = new ResponseBaseDto<ProductoDtoResponse>();
            try
            {
                TbProducto producto = new()
                {
                    Descripcion = request.Descripcion,
                    Nombre = request.Nombre,
                    IdMaeCategoria = request.IdMaeCategoria,
                    IdMaeMarca = request.IdMaeMarca
                };

                var resultado = await _productoRepository.AddAsync(producto);

                ProductoDtoResponse nuevo = new()
                {
                    Nombre = resultado.Nombre,
                    Descripcion = resultado.Descripcion,
                    IdMaeCategoria = resultado.IdMaeCategoria,
                    IdMaeMarca = resultado.IdMaeMarca
                };

                respuesta.Data = nuevo;
                respuesta.Message = "Producto registrado exitosamente";

            }
            catch (Exception ex)
            {
                respuesta.Success = false;
                respuesta.Message = ex.Message;
            }
            return respuesta;
        }

        public async Task<ResponsePaginacionDto<ListaProductoDtoResponse>> ListarAsync(PaginacionDtoRequest request)
        {
            return await _productoRepository.ListarAsync(request);
        }

        public async Task<ResponsePaginacionDto<ListaProductoDtoResponse>> Listar(PaginacionDtoRequest request)
        {
            ResponsePaginacionDto<ListaProductoDtoResponse> respuesta = new ResponsePaginacionDto<ListaProductoDtoResponse>();
            try
            {

                var resultado = await _productoRepository.ListAsync(
                    predicado: p => true,
                    selector: p => new ListaProductoDtoResponse
                    {
                        Id = p.Id,
                        Nombre = p.Nombre,
                        Descripcion = p.Descripcion,
                        Categoria = p.IdMaeCategoriaNavigation!.Valor,
                        Marca = p.IdMaeMarcaNavigation!.Valor
                    },
                    orderBy: p => p.FechaCreacion,
                    pagina: request.NumeroPagina,
                    filas: request.TotalFilas
                );

                respuesta.Data = resultado.Collection;
                respuesta.TotalFilas = resultado.Total;
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
}
