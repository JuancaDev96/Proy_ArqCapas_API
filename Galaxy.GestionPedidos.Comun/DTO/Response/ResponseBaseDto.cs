using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Comun.DTO.Response
{
    public class ResponseBaseDto
    {
        public string? Message { get; set; }
        public bool Success { get; set; } = true;

    }

    public class ResponseBaseDto<T> : ResponseBaseDto
    {
        public T? Data { get; set; }
    }

}
