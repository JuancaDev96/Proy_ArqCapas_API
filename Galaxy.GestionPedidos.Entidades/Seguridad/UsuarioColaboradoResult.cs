﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.GestionPedidos.Entidades.Seguridad
{
    public class UsuarioColaboradoResult
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correoelectronico { get; set; }
        public string puesto { get; set; }
        public bool estado { get; set; }
    }
}
