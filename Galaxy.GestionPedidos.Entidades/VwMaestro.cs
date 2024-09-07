using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class VwMaestro
{
    public string Maestro { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public int Identificador { get; set; }

    public string? ElementoMaestro { get; set; }
}
