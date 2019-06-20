using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Cargos
    {
        [Key]
        public int IdCargo { get; set; }
        public string NombreCargo { get; set; }
        public int Idestado { get; set; }

        public Cargos()
        {
            IdCargo = 0;
            NombreCargo = string.Empty;
            Idestado = 0;

        }
    }
}
