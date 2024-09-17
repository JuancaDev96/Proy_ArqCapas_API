using AutoMapper;
using Galaxy.GestionPedidos.Comun.DTO.Request.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Servicios.Mappers
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<ProductoDtoRequest, TbProducto>();
            CreateMap<TbProducto, ProductoDtoResponse>();
            CreateMap<ListaProductoDtoResponse, TbProducto>();
        }
    }
}
