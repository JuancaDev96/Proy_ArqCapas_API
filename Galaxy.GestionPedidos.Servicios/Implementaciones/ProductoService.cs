using AutoMapper;
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
        private IMapper _mapper; 
        public ProductoService(IProductoRepository productoRepository, IMapper mapper)
        {
            _productoRepository = productoRepository;
            _mapper = mapper;
        }

        public async Task<ResponseBaseDto> CreateAsync(ProductoDtoRequest request)
        {
            return await _productoRepository.Registrar(request);
        }

        public async Task<ResponseBaseDto<ProductoDtoResponse>> RegistrarAsync(ProductoDtoRequest request)
        {
            ResponseBaseDto<ProductoDtoResponse> respuesta = new ResponseBaseDto<ProductoDtoResponse>();
            try
            {

                var producto = _mapper.Map<TbProducto>(request);

                var resultado = await _productoRepository.AddAsync(producto);

                var nuevo = _mapper.Map<ProductoDtoResponse>(resultado);

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
