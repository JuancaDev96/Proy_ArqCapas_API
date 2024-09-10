using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Comun.DTO.Response.Usuario
{
    public class PermisosUsuarioDtoResponse
    {
        public int IdUsuario { get; set; }
        public string? Usuario { get; set; }
        public string? Colaborador { get; set; }
        public string? Puesto { get; set; }
        public string? Permiso { get; set; }
    }
}
