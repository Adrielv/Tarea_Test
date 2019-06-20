using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Permisos
    {
        [Key]
        public int Idpermiso { get; set; }
        public string Descripcion { get; set; }
        public string Funcionalidad { get; set; }

        public Permisos()
        {
            Idpermiso = 0;
            Descripcion = string.Empty;
            Funcionalidad = string.Empty;

        }
    }
}
