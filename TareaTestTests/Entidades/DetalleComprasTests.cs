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
    public class DetalleComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<DetalleCompras> repositorio = new Repositorio<DetalleCompras>();
            bool paso = false;
            DetalleCompras d = new DetalleCompras();

            d.Iddetallecompra = 1;
            d.Idcompra = 1;
            d.Idproducto = 1;
            d.Unidades = 10;
            d.Costounidad = 8;
            d.Total = 80;
            paso = repositorio.Guardar(d);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<DetalleCompras> repositorio = new Repositorio<DetalleCompras>();
            bool paso = false;
            DetalleCompras d = repositorio.Buscar(1);
            d.Idproducto = 2;
            paso = repositorio.Modificar(d);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<DetalleCompras> repositorio = new Repositorio<DetalleCompras>();
            DetalleCompras detalle = repositorio.Buscar(1);
            Assert.IsNotNull(detalle);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<DetalleCompras> repositorio = new Repositorio<DetalleCompras>();
            List<DetalleCompras> lista = new List<DetalleCompras>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<DetalleCompras> repositorio = new Repositorio<DetalleCompras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}