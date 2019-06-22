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
    public class EmpleadosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Empleados e = new Empleados();

            e.Idempleado = 1;
            e.Idestado = 1;
            e.Idcargo = 1;
            e.Idpersona = 1;

            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            bool paso = false;
            paso = repositorio.Guardar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            bool paso = false;
            Empleados e = repositorio.Buscar(1);
            e.Idcargo = 11;
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            Empleados e = repositorio.Buscar(1);
            Assert.IsNotNull(e);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            List<Empleados> lista = new List<Empleados>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Empleados> repositorio = new Repositorio<Empleados>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}