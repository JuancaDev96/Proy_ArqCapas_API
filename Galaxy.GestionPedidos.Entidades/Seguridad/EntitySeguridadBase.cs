using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Entidades.Seguridad
{
    public class EntitySeguridadBase
    {
        public int Id { get; set; }
        public bool Estado { get; set; }
        public DateTime Fechacreacion { get; set; } = DateTime.Now;

        public string Usuariocreacion { get; set; } = Environment.UserName;

        public DateTime? Fechamodificacion { get; set; }

        public string Usuariomodificacion { get; set; } = null!;
    }
}
