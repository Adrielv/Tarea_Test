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
    public class Usuario_has_permisoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuario_has_permiso u = new Usuario_has_permiso();
            u.Idusuario = 1;
            u.Idpermiso = 1;

            Repositorio<Usuario_has_permiso> repositorio = new Repositorio<Usuario_has_permiso>();
            bool paso = false;
            paso = repositorio.Guardar(u);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Usuario_has_permiso> repositorio = new Repositorio<Usuario_has_permiso>();
            bool paso = false;
            Usuario_has_permiso u = repositorio.Buscar(1);
            u.Idpermiso = 11;
            paso = repositorio.Modificar(u);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Usuario_has_permiso> repositorio = new Repositorio<Usuario_has_permiso>();
            Usuario_has_permiso u = repositorio.Buscar(1);
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Usuario_has_permiso> repositorio = new Repositorio<Usuario_has_permiso>();
            List<Usuario_has_permiso> lista = new List<Usuario_has_permiso>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Usuario_has_permiso> repositorio = new Repositorio<Usuario_has_permiso>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}