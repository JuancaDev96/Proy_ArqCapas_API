using Azure.Core;
using Galaxy.GestionPedidos.AccesoDatos.Contexto;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Entidades;
using Galaxy.GestionPedidos.Entidades.Seguridad;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Repositorios.Implementaciones
{
    public class UsuarioRepositorio : RepositorioSeguridadBase<Colaboradorusuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SeguridadDbContext context)
        : base(context)
        {
        }

        public async Task<ResponseBaseDto<UsuarioColaboradoResult>> ObtenerColaboradorPorUsuario(string usuario)
        {
            ResponseBaseDto<UsuarioColaboradoResult> respuesta = new();
            try
            {
                var colaborador = await Context.UsuarioColaboradoResult
                 .FromSqlRaw("SELECT * FROM ObtenerColaboradoresPorUsuario({0})", usuario)
                 .FirstOrDefaultAsync();

                respuesta.Data = colaborador;
                respuesta.Message = "Producto registrado exitosamente";
                respuesta.Success = true;
            }
            catch (Exception ex)
            {
                respuesta.Message += ex.Message;
                respuesta.Success = false;
            }
            return respuesta;

            
        }
    }
}
