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

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Personas> repositorio;
            repositorio = new Repositorio<Personas>();
           // Assert.IsTrue(repositorio.Modificar(new Personas(1,1, "Walder", "De Jesus", "Reyes", DateTime.Now, "8091232123", "Walder@walder.com", "M", 1, "Libertad", 1)));
        
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Personas> repositorio;
            repositorio = new Repositorio<Personas>();

            Assert.IsNotNull(repositorio.Buscar(1));
        }/*

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