using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Usuario_has_permiso
    {
        [Key]
        public int Idusuario { get; set; }
        public int Idpermiso { get; set; }

        public Usuario_has_permiso()
        {
            Idusuario = 0;
            Idpermiso = 0;

        }
    }
}
