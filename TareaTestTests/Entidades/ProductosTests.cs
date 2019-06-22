using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ciudades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciudades.BLL;

namespace TareaTest.BLL
{
    [TestClass()]
    public class ProductosTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Productos p = new Productos();

            p.Idproducto = 1;
            p.Nombre = "Adriel";
            p.Descripcion = "qqqqqq";
            p.Fechafabricacion = DateTime.Now;
            p.Costocompra = 2;
            p.Stock = 10;
            p.Idunidadmedida = 1;
            p.Idimagen = 1;
            p.Idcategoria = 1;
            p.Idmarca = 1;
            p.Idmodelo = 1;

            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            bool paso = false;
            paso = repositorio.Guardar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            bool paso = false;
            Productos p = repositorio.Buscar(1);
            p.Nombre = "ADD";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            Productos p = repositorio.Buscar(1);
            Assert.IsNotNull(p);
        }


        [TestMethod()]
        public void GetListTest()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Repositorio<Productos> repositorio = new Repositorio<Productos>();
            bool paso = false;
            paso = repositorio.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}