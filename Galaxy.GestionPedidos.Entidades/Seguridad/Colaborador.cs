using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades.Seguridad;

public partial class Colaborador
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string? Correoelectronico { get; set; }

    public string? Documentoidentidad { get; set; }

    public int Idpuesto { get; set; }

    public bool Estado { get; set; }

    public DateTime Fechacreacion { get; set; }

    public string Usuariocreacion { get; set; } = null!;

    public DateTime? Fechamodificacion { get; set; }

    public string Usuariomodificacion { get; set; } = null!;

    public virtual ICollection<Colaboradorusuario> Colaboradorusuarios { get; set; } = new List<Colaboradorusuario>();

    public virtual Puesto IdpuestoNavigation { get; set; } = null!;
}
