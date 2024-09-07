using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbPedidoDetalle : EntityBase
{
    public int? IdPedido { get; set; }

    public int? IdProveedorProducto { get; set; }

    public string? Comentario { get; set; }

    public decimal? PrecioUnitario { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? TotalBruto { get; set; }

    public decimal? TotalNeto { get; set; }

    public virtual TbPedido? IdPedidoNavigation { get; set; }

    public virtual TbProveedorProducto? IdProveedorProductoNavigation { get; set; }
}
