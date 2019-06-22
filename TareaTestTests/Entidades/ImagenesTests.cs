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
    public class ImagenesTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Imagenes i = new Imagenes();
            i.Idimagen = 1;
            i.rutaimagen = "QQQQ";

            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            bool paso = false;
            paso = repositorio.Guardar(i);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            bool paso = false;
            Imagenes i = repositorio.Buscar(1);
            i.rutaimagen = "mmmm";
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            Imagenes i = repositorio.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            List<Imagenes> lista = new List<Imagenes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Imagenes> repositorio = new Repositorio<Imagenes>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}