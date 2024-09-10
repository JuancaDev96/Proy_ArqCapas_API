﻿using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades.Seguridad;

public partial class Gerencium
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public bool Estado { get; set; }

    public DateTime Fechacreacion { get; set; }

    public string Usuariocreacion { get; set; } = null!;

    public DateTime? Fechamodificacion { get; set; }

    public string Usuariomodificacion { get; set; } = null!;

    public virtual ICollection<Puesto> Puestos { get; set; } = new List<Puesto>();
}
