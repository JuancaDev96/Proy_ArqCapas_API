using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbPedido : EntityBase
{
    public int? IdCliente { get; set; }

    public int? IdColaborador { get; set; }

    public decimal? TotalBruto { get; set; }

    public decimal? TotalNeto { get; set; }

    public decimal? AdelantoPedido { get; set; }

    public virtual TbCliente? IdClienteNavigation { get; set; }

    public virtual ICollection<TbPedidoDetalle> TbPedidoDetalles { get; set; } = new List<TbPedidoDetalle>();

    public virtual ICollection<TbTrackingPedido> TbTrackingPedidos { get; set; } = new List<TbTrackingPedido>();
}
