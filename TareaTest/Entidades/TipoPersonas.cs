using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class TipoPersonas
    {
        [Key]
        public int IdTipoPersona { get; set; }
        public string Nombre { get; set; }

        public TipoPersonas()
        {
            IdTipoPersona = 0;
            Nombre = string.Empty;

        }
    }
}
