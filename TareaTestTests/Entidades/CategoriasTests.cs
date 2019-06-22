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
    public class CategoriasTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Categorias c = new Categorias();
            c.Idcategoria = 1;
            c.Nombrecategoria = "pedro";
            c.Descripcion = "qqqqq";
            Repositorio<Categorias> repositoriobase = new Repositorio<Categorias>();
            bool paso = false;
            paso = repositoriobase.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod]
        public void ModificarTest()
        {
            Repositorio<Categorias> repositorio = new Repositorio<Categorias>();
            bool paso = false;
            Categorias c = repositorio.Buscar(1);
            c.Nombrecategoria = "lol";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Categorias> repositorio = new Repositorio<Categorias>();
            Categorias c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Categorias> repositorio = new Repositorio<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod]
        public void EliminarTest()
        {
            Repositorio<Categorias> repositorio = new Repositorio<Categorias>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}
