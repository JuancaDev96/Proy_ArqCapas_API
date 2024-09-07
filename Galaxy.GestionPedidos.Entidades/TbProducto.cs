using Galaxy.GestionPedidos.Entidades;
using System;
using System.Collections.Generic;

namespace Galaxy.GestionPedidos.Entidades;

public partial class TbProducto : EntityBase
{

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? IdMaeMarca { get; set; }

    public int? IdMaeCategoria { get; set; }

    public virtual TbMaestroDetalle? IdMaeCategoriaNavigation { get; set; }

    public virtual TbMaestroDetalle? IdMaeMarcaNavigation { get; set; }

    public virtual ICollection<TbProveedorProducto> TbProveedorProductos { get; set; } = new List<TbProveedorProducto>();
}
