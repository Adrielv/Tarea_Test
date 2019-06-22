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
    public class CargosTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Cargos c = new Cargos();
            c.IdCargo = 1;
            c.NombreCargo = "Gerente";
            c.Idestado = 1;

            Repositorio<Cargos> repositorio = new Repositorio<Cargos>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Cargos> repositorio = new Repositorio<Cargos>();
            bool paso = false;
            Cargos c = repositorio.Buscar(1);
            c.NombreCargo = "VGerente";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Cargos> repositoriobase = new Repositorio<Cargos>();
            Cargos c = repositoriobase.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Cargos> repositorio = new Repositorio<Cargos>();
            List<Cargos> lista = new List<Cargos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Cargos> repositoriobase = new Repositorio<Cargos>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}