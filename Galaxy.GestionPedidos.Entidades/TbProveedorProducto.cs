using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbProveedorProducto : EntityBase
{
    
    public int? IdProveedor { get; set; }

    public int? IdProducto { get; set; }

    public decimal? PrecioBruto { get; set; }

    public decimal? PrecioNeto { get; set; }

    public decimal? Stock { get; set; }

    public virtual TbProducto? IdProductoNavigation { get; set; }

    public virtual TbProveedor? IdProveedorNavigation { get; set; }

    public virtual ICollection<TbPedidoDetalle> TbPedidoDetalles { get; set; } = new List<TbPedidoDetalle>();
}
