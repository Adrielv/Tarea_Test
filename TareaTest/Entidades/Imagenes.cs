using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Imagenes
    {
        [Key]

        public int Idimagen { get; set; }
        public string rutaimagen { get; set; }

        public Imagenes()
        {

            this.Idimagen = 0;
            this.rutaimagen = string.Empty;

        }
    }
}
