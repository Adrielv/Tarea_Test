using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Usuarios
    {
        [Key]
        public int Idusuario { get; set; }
        public int Idempleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }

        public Usuarios()
        {
            Idusuario = 0;
            Idempleado = 0;
            NombreUsuario = string.Empty;
            Clave = string.Empty;

        }
    }
}
