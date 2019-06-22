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
    public class ModelosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Modelos m = new Modelos();
            m.Idmodelo = 1;
            m.Nombremodelo = "qqqq";

            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            bool paso = false;
            paso = repositorio.Guardar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            bool paso = false;
            Modelos m = repositorio.Buscar(1);
            m.Nombremodelo = "aaaa";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            Modelos m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            List<Modelos> lista = new List<Modelos>();
            lista = repositorio.GetList(m => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Modelos> repositorio = new Repositorio<Modelos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}