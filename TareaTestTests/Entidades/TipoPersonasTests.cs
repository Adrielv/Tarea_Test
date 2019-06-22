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
    public class TipoPersonasTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            TipoPersonas t = new TipoPersonas();
            t.IdTipoPersona = 1;
            t.Nombre = "Adriel";
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            bool estado = false;
            estado = repositorio.Guardar(t);
            Assert.AreEqual(true, estado);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            bool paso = false;
            TipoPersonas t = repositorio.Buscar(1);
            t.Nombre = "qqqqq";
            paso = repositorio.Modificar(t);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            TipoPersonas t = repositorio.Buscar(1);
            Assert.IsNotNull(t);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            List<TipoPersonas> lista = new List<TipoPersonas>();
            lista = repositorio.GetList(t => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<TipoPersonas> repositorio = new Repositorio<TipoPersonas>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}