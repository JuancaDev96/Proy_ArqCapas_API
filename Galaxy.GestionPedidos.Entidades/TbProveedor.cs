using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbProveedor : EntityBase
{
    public string? RazonSocial { get; set; }

    public string NombreComercial { get; set; } = null!;

    public string DocumentoIdentidad { get; set; } = null!;

    public int IdMaeTipoDocumento { get; set; }

    public string Celular { get; set; } = null!;

    public string? CorreoElectronico { get; set; }

    public int IdMaeRubro { get; set; }

    public virtual TbMaestroDetalle IdMaeRubroNavigation { get; set; } = null!;

    public virtual ICollection<TbProveedorProducto> TbProveedorProductos { get; set; } = new List<TbProveedorProducto>();
}
