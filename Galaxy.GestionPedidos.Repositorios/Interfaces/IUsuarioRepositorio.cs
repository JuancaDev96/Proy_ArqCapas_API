using Galaxy.GestionPedidos.Comun.DTO.Response;
using Galaxy.GestionPedidos.Entidades;
using Galaxy.GestionPedidos.Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioSeguridadBase<Colaboradorusuario>
    {
        Task<ResponseBaseDto<UsuarioColaboradoResult>> ObtenerColaboradorPorUsuario(string usuario);
    }
}
