using System;
using System.Collections.Generic;
using Galaxy.GestionPedidos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Galaxy.GestionPedidos.AccesoDatos.Contexto;

public partial class BdPedidosContext : DbContext
{
    public BdPedidosContext()
    {
    }

    public BdPedidosContext(DbContextOptions<BdPedidosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbCliente> TbClientes { get; set; }

    public virtual DbSet<TbMaestro> TbMaestros { get; set; }

    public virtual DbSet<TbMaestroDetalle> TbMaestroDetalles { get; set; }

    public virtual DbSet<TbPedido> TbPedidos { get; set; }

    public virtual DbSet<TbPedidoDetalle> TbPedidoDetalles { get; set; }

    public virtual DbSet<TbProducto> TbProductos { get; set; }

    public virtual DbSet<TbProveedor> TbProveedors { get; set; }

    public virtual DbSet<TbProveedorProducto> TbProveedorProductos { get; set; }

    public virtual DbSet<TbTrackingPedido> TbTrackingPedidos { get; set; }

    public virtual DbSet<VwMaestro> VwMaestros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbClient__3214EC0766FC3892");

            entity.ToTable("TbCliente");

            entity.Property(e => e.Id).HasComment("Identificador del registro, autoincremental");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Numero de celular del cliente");
            entity.Property(e => e.Contacto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre de la persona de contacto del cliente");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Correo electronico del cliente");
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Numero de documento de identidad");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasComment("0 - Inactivo / 1 - Activo");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación del registro")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion)
                .HasComment("Fecha de ultima modificacion")
                .HasColumnType("datetime");
            entity.Property(e => e.IdMaeRubro).HasComment("Identificador del Rubro - Maestro");
            entity.Property(e => e.IdMaeTipoDocumento).HasComment("Identificador del tipo de documento de identidad - Maestro");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre comercial o nombre y apellidos del cliente");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Razon social del cliente");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql")
                .HasComment("Nombre de usuario del registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de ultima modificacion");

            entity.HasOne(d => d.IdMaeRubroNavigation).WithMany(p => p.TbClienteIdMaeRubroNavigations)
                .HasForeignKey(d => d.IdMaeRubro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCliente_TbMaestroDetalle_Rubro");

            entity.HasOne(d => d.IdMaeTipoDocumentoNavigation).WithMany(p => p.TbClienteIdMaeTipoDocumentoNavigations)
                .HasForeignKey(d => d.IdMaeTipoDocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbCliente_TbMaestroDetalle_TipoDocumento");
        });

        modelBuilder.Entity<TbMaestro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbMaestr__3214EC0742A44BBF");

            entity.ToTable("TbMaestro");

            entity.HasIndex(e => e.Codigo, "UQ__TbMaestr__06370DAC7FF0457E").IsUnique();

            entity.Property(e => e.Id).HasComment("Identificador del registro, autoincremental");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Valor constante para acceder al registro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("Descripcion del maestro");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasComment("0 - Inactivo / 1 - Activo");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha de creación del registro")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion)
                .HasComment("Fecha de ultima modificacion")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Nombre del maestro");
            entity.Property(e => e.TipoMaestro)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Define el tipo de maestro : MAE = MAESTRO, CFG = CONFIGURACION");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql")
                .HasComment("Nombre de usuario del registro");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("Usuario de ultima modificacion");
        });

        modelBuilder.Entity<TbMaestroDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbMaestr__3214EC072E9BC457");

            entity.ToTable("TbMaestroDetalle");

            entity.HasIndex(e => e.Codigo, "UQ__TbMaestr__06370DAC896E6BBB").IsUnique();

            entity.Property(e => e.Id).HasComment("Identificador del registro, autoincremental");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Valor constante para acceder al registro");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.IdMaestro).HasComment("Identificador de la cabecera Maestro");
            entity.Property(e => e.TipoMaestro)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMaestroNavigation).WithMany(p => p.TbMaestroDetalles)
                .HasForeignKey(d => d.IdMaestro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TbMaestroDetalle_TbMaestro");
        });

        modelBuilder.Entity<TbPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbPedido__3214EC07D996118B");

            entity.ToTable("TbPedido");

            entity.Property(e => e.AdelantoPedido).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.TotalBruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalNeto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TbPedidos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_TbPedido_TbCliente");
        });

        modelBuilder.Entity<TbPedidoDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbPedido__3214EC07D35D6CB6");

            entity.ToTable("TbPedidoDetalle");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Comentario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalBruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalNeto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.TbPedidoDetalles)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK_TbPedidoDetalle_TbPedido");

            entity.HasOne(d => d.IdProveedorProductoNavigation).WithMany(p => p.TbPedidoDetalles)
                .HasForeignKey(d => d.IdProveedorProducto)
                .HasConstraintName("FK_TbPedidoDetalle_TbProveedorProducto");
        });

        modelBuilder.Entity<TbProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbProduc__3214EC0788DFE60D");

            entity.ToTable("TbProducto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMaeCategoriaNavigation).WithMany(p => p.TbProductoIdMaeCategoriaNavigations)
                .HasForeignKey(d => d.IdMaeCategoria)
                .HasConstraintName("FK_TbProducto_TbMaestroDetalle_Categoria");

            entity.HasOne(d => d.IdMaeMarcaNavigation).WithMany(p => p.TbProductoIdMaeMarcaNavigations)
                .HasForeignKey(d => d.IdMaeMarca)
                .HasConstraintName("FK_TbProducto_TbMaestroDetalle_Marca");
        });

        modelBuilder.Entity<TbProveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbProvee__3214EC07CE87A9B2");

            entity.ToTable("TbProveedor");

            entity.Property(e => e.Celular)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DocumentoIdentidad)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMaeRubroNavigation).WithMany(p => p.TbProveedors)
                .HasForeignKey(d => d.IdMaeRubro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proveedor_TbMaestroDetalle_Rubro");
        });

        modelBuilder.Entity<TbProveedorProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbProvee__3214EC07BABD94F8");

            entity.ToTable("TbProveedorProducto");

            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.PrecioBruto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioNeto).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Stock).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.TbProveedorProductos)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK_TbProveedorProducto_TbProducto");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.TbProveedorProductos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK_TbProveedorProducto_TbProveedor");
        });

        modelBuilder.Entity<TbTrackingPedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TbTracki__3214EC0714515647");

            entity.ToTable("TbTrackingPedido");

            entity.Property(e => e.Comentario)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sql");
            entity.Property(e => e.UsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdMaeEstadoPedidoNavigation).WithMany(p => p.TbTrackingPedidos)
                .HasForeignKey(d => d.IdMaeEstadoPedido)
                .HasConstraintName("FK_TbTrackingPedido_TbMaestroDetalle");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.TbTrackingPedidos)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK_TbTrackingPedido_TbPedido");
        });

        modelBuilder.Entity<VwMaestro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vw_Maestros");

            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ElementoMaestro)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Identificador).HasColumnName("identificador");
            entity.Property(e => e.Maestro)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
