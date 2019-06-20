using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Categorias
    {

        [Key]
        public int Idcategoria { get; set; }
        public string Nombrecategoria { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            Idcategoria = 0;
            Nombrecategoria = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
