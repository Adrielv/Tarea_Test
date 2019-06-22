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
    public class UsuariosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Idusuario = 1;
            usuarios.Idempleado = 1;
            usuarios.NombreUsuario = "QQQ";
            usuarios.Clave = "AAA";

            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            bool paso = false;
            paso = repositorio.Guardar(usuarios);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            bool paso = false;
            Usuarios usuarios = repositorio.Buscar(1);
            usuarios.NombreUsuario = "jUAN";
            paso = repositorio.Modificar(usuarios);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuarios = repositorio.Buscar(1);
            Assert.IsNotNull(usuarios);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(u => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}