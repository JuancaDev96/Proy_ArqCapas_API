﻿using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades.Seguridad;

public partial class Puesto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int Idgerencia { get; set; }

    public bool Estado { get; set; }

    public DateTime Fechacreacion { get; set; }

    public string Usuariocreacion { get; set; } = null!;

    public DateTime? Fechamodificacion { get; set; }

    public string Usuariomodificacion { get; set; } = null!;

    public virtual ICollection<Colaborador> Colaboradors { get; set; } = new List<Colaborador>();

    public virtual Gerencium IdgerenciaNavigation { get; set; } = null!;
}
