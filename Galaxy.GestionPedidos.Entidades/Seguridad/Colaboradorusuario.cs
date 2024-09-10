using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades.Seguridad;

public partial class Colaboradorusuario : EntitySeguridadBase
{
    public int Idcolaborador { get; set; }

    public string? Usuario { get; set; }

    public string? Clave { get; set; }

    public DateTime? Bloqueadohasta { get; set; }

    public DateTime? Ultimobloqueo { get; set; }

    public int? Intentosfallidos { get; set; }

    public virtual ICollection<Colaboradorusuariopermiso> Colaboradorusuariopermisos { get; set; } = new List<Colaboradorusuariopermiso>();

    public virtual Colaborador IdcolaboradorNavigation { get; set; } = null!;
}
