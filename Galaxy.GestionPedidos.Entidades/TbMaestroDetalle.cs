using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbMaestroDetalle : EntityBase
{
   
    /// <summary>
    /// Identificador de la cabecera Maestro
    /// </summary>
    public int IdMaestro { get; set; }

    /// <summary>
    /// Valor constante para acceder al registro
    /// </summary>
    public string Codigo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Valor { get; set; }

    public string? TipoMaestro { get; set; }

    public virtual TbMaestro IdMaestroNavigation { get; set; } = null!;

    public virtual ICollection<TbCliente> TbClienteIdMaeRubroNavigations { get; set; } = new List<TbCliente>();

    public virtual ICollection<TbCliente> TbClienteIdMaeTipoDocumentoNavigations { get; set; } = new List<TbCliente>();

    public virtual ICollection<TbProducto> TbProductoIdMaeCategoriaNavigations { get; set; } = new List<TbProducto>();

    public virtual ICollection<TbProducto> TbProductoIdMaeMarcaNavigations { get; set; } = new List<TbProducto>();

    public virtual ICollection<TbProveedor> TbProveedors { get; set; } = new List<TbProveedor>();

    public virtual ICollection<TbTrackingPedido> TbTrackingPedidos { get; set; } = new List<TbTrackingPedido>();
}
