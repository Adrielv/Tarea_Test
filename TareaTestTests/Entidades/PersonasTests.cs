using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ciudades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaTest.BLL;

using Ciudades.BLL;

namespace TareaTest.BLL
{
    [TestClass()]
    public class PersonasTests
    {
        [TestMethod()]

        public void GuardarTest()
        {
            Repositorio<Personas> repositorio;
            repositorio = new Repositorio<Personas>();
            Assert.IsTrue(repositorio.Guardar(new Personas()));
        }

       /* [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            bool paso = false;
            Persona p = repositorio.Buscar(1);
            p.Nombre = "franchy";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            Persona p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Persona> repositorio = new Repositorio<Persona>();
            List<Persona> lista = new List<Persona>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }*/
    }
}