using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Comun.DTO.Request.Producto
{
    public class ProductoDtoRequest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = Constantes.MensajeCampoRequerido)]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = Constantes.MensajeCampoRequerido)]
        public string Descripcion { get; set; } = default!;

        [DeniedValues(0, ErrorMessage = Constantes.MensajeCampoRequerido)]
        public int IdMaeMarca { get; set; }

        [DeniedValues(0, ErrorMessage = Constantes.MensajeCampoRequerido)]
        public int IdMaeCategoria { get; set; }
    }
}
