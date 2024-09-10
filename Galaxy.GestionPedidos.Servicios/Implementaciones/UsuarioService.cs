using Galaxy.GestionPedidos.Comun.DTO.Request;
using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Comun.DTO.Response.Producto;
using Galaxy.GestionPedidos.Comun.DTO.Response.Usuario;
using Galaxy.GestionPedidos.Entidades.Seguridad;
using Galaxy.GestionPedidos.Repositorios.Implementaciones;
using Galaxy.GestionPedidos.Repositorios.Interfaces;
using Galaxy.GestionPedidos.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Servicios.Implementaciones
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepositorio _repositorio;
        public UsuarioService(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public async Task<ResponseBaseDto<UsuarioColaboradoResult>> ObtenerColaboradoresPorUsuario(string usuario)
        {
            return await _repositorio.ObtenerColaboradorPorUsuario(usuario);
        }

        public async Task<ResponseBaseDto<PermisosUsuarioDtoResponse>> ListarPermisos(string usuario)
        {
            ResponseBaseDto<PermisosUsuarioDtoResponse> respuesta = new ResponseBaseDto<PermisosUsuarioDtoResponse>();
            try
            {

                var resultado = await _repositorio.ListAsync(
                    predicado: p => p.Usuario == usuario,
                    selector: p => new PermisosUsuarioDtoResponse
                    {
                        IdUsuario = p.Id,
                        Colaborador = $"{p.IdcolaboradorNavigation.Nombre} {p.IdcolaboradorNavigation.Apellidos}",
                        Puesto = p.IdcolaboradorNavigation.IdpuestoNavigation.Nombre,
                        Usuario = p.Usuario,
                        Permiso = string.Join(",", p.Colaboradorusuariopermisos.Select(p=>p.IdpermisoNavigation.Nombre))
                    });

                respuesta.Data = resultado.FirstOrDefault();
                respuesta.Message = "Permisos listado existosamente";

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
