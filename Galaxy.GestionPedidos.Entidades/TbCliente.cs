using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbCliente : EntityBase
{
   
    /// <summary>
    /// Razon social del cliente
    /// </summary>
    public string? RazonSocial { get; set; }

    /// <summary>
    /// Nombre comercial o nombre y apellidos del cliente
    /// </summary>
    public string NombreComercial { get; set; } = null!;

    /// <summary>
    /// Numero de documento de identidad
    /// </summary>
    public string DocumentoIdentidad { get; set; } = null!;

    /// <summary>
    /// Identificador del tipo de documento de identidad - Maestro
    /// </summary>
    public int IdMaeTipoDocumento { get; set; }

    /// <summary>
    /// Nombre de la persona de contacto del cliente
    /// </summary>
    public string Contacto { get; set; } = null!;

    /// <summary>
    /// Numero de celular del cliente
    /// </summary>
    public string Celular { get; set; } = null!;

    /// <summary>
    /// Correo electronico del cliente
    /// </summary>
    public string? CorreoElectronico { get; set; }

    /// <summary>
    /// Identificador del Rubro - Maestro
    /// </summary>
    public int IdMaeRubro { get; set; }

    

    public virtual TbMaestroDetalle IdMaeRubroNavigation { get; set; } = null!;

    public virtual TbMaestroDetalle IdMaeTipoDocumentoNavigation { get; set; } = null!;

    public virtual ICollection<TbPedido> TbPedidos { get; set; } = new List<TbPedido>();
}
