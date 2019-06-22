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
    public class TipoComprobantesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoComprobantes t = new TipoComprobantes();
            t.Idtipocomprobante = 1;
            t.Nombrecomprobante = "QQQQQ";

            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            bool paso = false;
            paso = repositorio.Guardar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            TipoComprobantes t = repositorio.Buscar(1);
            bool paso = false;
            t.Nombrecomprobante = "OOOOOO";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            TipoComprobantes t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            List<TipoComprobantes> lista = new List<TipoComprobantes>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<TipoComprobantes> repositorio = new Repositorio<TipoComprobantes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}