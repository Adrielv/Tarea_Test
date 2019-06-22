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
    public class ProvedoresTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Provedores p = new Provedores();
            p.Idproveedor = 1;
            p.Idpersona = 1;

            Repositorio<Provedores> repositorio = new Repositorio<Provedores>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Provedores> repositorio = new Repositorio<Provedores>();
            bool paso = false;
            Provedores p = repositorio.Buscar(2);
            p.Idpersona = 5;
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Provedores> repositorio = new Repositorio<Provedores>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }


        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Provedores> repositorio = new Repositorio<Provedores>();
            Provedores p = repositorio.Buscar(2);
            Assert.IsNotNull(p);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Provedores> repositorio = new Repositorio<Provedores>();
            List<Provedores> lista = new List<Provedores>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}