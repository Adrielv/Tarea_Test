using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Empleados
    {
        [Key]
        public int Idempleado { get; set; }
        public int Idestado { get; set; }
        public int Idcargo { get; set; }
        public int Idpersona { get; set; }


        public Empleados()
        {
            Idempleado = 0;
            Idestado = 0;
            Idcargo = 0;
            Idpersona = 0;

        }
    }
}
