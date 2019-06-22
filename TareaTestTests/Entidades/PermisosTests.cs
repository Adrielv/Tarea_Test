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
    public class PermisosTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            Permisos p = new Permisos();
            p.Idpermiso = 2;
            p.Descripcion = "qqqqq";
            p.Funcionalidad = "aaaaa";

            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            bool paso = false;
            Permisos p = repositorio.Buscar(2);
            p.Funcionalidad = "zzzz";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            Permisos p = repositorio.Buscar(3);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            List<Permisos> lista = new List<Permisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Permisos> repositorio = new Repositorio<Permisos>();
            bool paso = false;
            paso = repositorio.Eliminar(3);
            Assert.AreEqual(true, paso);
        }
    }
}