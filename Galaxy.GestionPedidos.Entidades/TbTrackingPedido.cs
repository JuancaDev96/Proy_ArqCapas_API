using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbTrackingPedido : EntityBase
{
    public int? IdPedido { get; set; }

    public int? IdMaeEstadoPedido { get; set; }

    public string? Comentario { get; set; }

    public virtual TbMaestroDetalle? IdMaeEstadoPedidoNavigation { get; set; }

    public virtual TbPedido? IdPedidoNavigation { get; set; }
}
