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
    public class EstadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            bool paso = false;
            Estados e = new Estados();
            e.IdEstado = 1;
            e.FechaInicio = DateTime.Now;
            e.FechaFin = DateTime.Today;
            e.estado = "QQQQQ";

            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            bool paso = false;
            Estados e = repositorio.Buscar(1);
            e.estado = "aaaaaa";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            Estados e = repositorio.Buscar(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            List<Estados> lista = new List<Estados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Estados> repositorio = new Repositorio<Estados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}