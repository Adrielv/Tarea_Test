using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
   public class Productos
    {
        [Key]
        public int Idproducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fechafabricacion { get; set; }
        public double Costocompra { get; set; }
        public double Stock { get; set; }
        public int Idunidadmedida { get; set; }
        public int Idimagen { get; set; }
        public int Idcategoria { get; set; }
        public int Idmarca { get; set; }
        public int Idmodelo { get; set; }

        public Productos()
        {
            Idproducto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Fechafabricacion = DateTime.Now;
            Costocompra = 0;
            Stock = 0;
            Idunidadmedida = 0;
            Idimagen = 0;
            Idcategoria = 0;
            Idmarca = 0;
            Idmodelo = 0;

        }
    }
}
