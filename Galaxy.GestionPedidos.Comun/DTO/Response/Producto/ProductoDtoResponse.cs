using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Comun.DTO.Response.Producto
{
    public class ProductoDtoResponse
    {
        public int Id { get; set; }

        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }

        public int? IdMaeMarca { get; set; }

        public int? IdMaeCategoria { get; set; }
    }
}
