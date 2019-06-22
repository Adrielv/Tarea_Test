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
    public class MarcasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Marcas m = new Marcas();
            m.Idmarca = 1;
            m.Nombremarca = "Adriel";

            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            bool paso = false;
            paso = repositorio.Guardar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            bool paso = false;
            Marcas m = repositorio.Buscar(1);
            m.Nombremarca = "Motors";
            paso = repositorio.Modificar(m);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            Marcas m = repositorio.Buscar(1);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            List<Marcas> lista = new List<Marcas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Marcas> repositorio = new Repositorio<Marcas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}