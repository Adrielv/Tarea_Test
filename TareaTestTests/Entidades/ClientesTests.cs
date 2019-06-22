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
    public class ClientesTests
    {
        [TestMethod]
        public void GuardarTest()
        {
            Clientes c = new Clientes();
            c.IdCliente = 1;
            c.Nombre = "Adriel";
            

            Repositorio<Clientes> repositorio = new Repositorio<Clientes>();
            bool paso = false;
            paso = repositorio.Guardar(c);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Clientes> repositorio = new Repositorio<Clientes>();
            bool paso = false;
            Clientes c = repositorio.Buscar(1);
            c.Nombre = "Jose";
            paso = repositorio.Modificar(c);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Clientes> repositorio = new Repositorio<Clientes>();
            Clientes c = repositorio.Buscar(1);
            Assert.IsNotNull(c);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Clientes> repositorio = new Repositorio<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(c => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Clientes> db = new Repositorio<Clientes>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}