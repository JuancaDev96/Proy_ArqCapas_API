using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Comun.DTO.Response.Usuario;
using Galaxy.GestionPedidos.Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        Task<ResponseBaseDto<UsuarioColaboradoResult>> ObtenerColaboradoresPorUsuario(string usuario);
        Task<ResponseBaseDto<PermisosUsuarioDtoResponse>> ListarPermisos(string usuario);
    }
}
