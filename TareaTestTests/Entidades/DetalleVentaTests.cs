using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ciudades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciudades.BLL;

namespace Ciudades.Entidades.Tests
{
    [TestClass()]
    public class DetalleVentaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool paso = false;
            DetalleVenta d = new DetalleVenta();

            d.Iddetalleventa = 1;
            d.Idventa = 1;
            d.Idproducto = 1;
            d.Unidades = 2;
            d.Costounidad = 10;
            d.Descuentounidad = 5;
            d.Total = 10;
            paso = repositorio.Guardar(d);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool paso = false;
            DetalleVenta d = repositorio.Buscar(1);
            d.Unidades = 20;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            DetalleVenta d = repositorio.Buscar(1);
            Assert.IsNotNull(d);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            List<DetalleVenta> lista = new List<DetalleVenta>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<DetalleVenta> repositorio = new Repositorio<DetalleVenta>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}