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
            Repositorio<Personas> db = new Repositorio<Personas>();

            Personas personas = new Personas();

            personas.PersonaId = 1;
            personas.Dni = 1;
            personas.Nombre = "QQ";
            personas.Materno = "QQ";
            personas.Paterno = "QQ";
            personas.FechaNacimiento = DateTime.Now;
            personas.Telefono = "12W";
            personas.Correo = "QQQ@gmail.com";
            personas.Sexo = "M";
            personas.Idimagen = 1;
            personas.Direccion = "QQQ";
            personas.Idtipopersona = 1;

            Repositorio<Personas> repositorio = new Repositorio<Personas>();
            bool paso = false;
            paso = repositorio.Guardar(personas);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>();
            bool paso = false;
            Personas p = repositorio.Buscar(1);
            p.Nombre = "Adriel";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();

            Assert.IsNotNull(db.Buscar(1));

        }
        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();

            Assert.IsNotNull(db.GetList(p => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Personas> db = new Repositorio<Personas>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}