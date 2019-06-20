using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciudades.Entidades;

namespace Ciudades.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<DetalleCompras> DetalleCompras { get; set; }
        public DbSet<DetalleVenta> Detalleventas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelo { get; set; }
        public DbSet<Permisos> Permiso { get; set; }
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<Provedores> Proveedor { get; set; }
        public DbSet<TipoComprobantes> Tipocomprobante { get; set; }
        public DbSet<UnidadMedida> UnidadMedida { get; set; }
        public DbSet<TipoPersonas> Tipopersona { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Ventas> Venta { get; set; }
        public DbSet<Usuario_has_permiso> Usuario_has_permiso { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
