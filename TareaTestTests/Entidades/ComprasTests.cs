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
    public class ComprasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Compras c = new Compras();
            c.Idcompra = 1;
            c.Idusuario = 1;
            c.Fechacompra = DateTime.Now;
            c.Idproveedor = 1;
            c.Idtipocomprobante = 1;
            c.Costocomprobante = 1;
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            bool paso = false;
            Compras c = repositorio.Buscar(1);
            c.Idproveedor = 10;
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            Compras c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            List<Compras> lista = new List<Compras>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Compras> repositorio = new Repositorio<Compras>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}