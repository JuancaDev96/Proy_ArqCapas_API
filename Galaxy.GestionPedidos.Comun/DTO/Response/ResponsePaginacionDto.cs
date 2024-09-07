using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Comun.DTO.Response
{
    public class ResponsePaginacionDto<T> : ResponseBaseDto
    {
        public ICollection<T>? Data { get; set; }
        public int TotalPaginas { get; set; }
        public int TotalFilas { get; set; }
    }
}
