using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class UnidadMedida
    {
        [Key]
        public int Idunidadmedida { get; set; }
        public string Nombreunidad { get; set; }

        public UnidadMedida()
        {
            Idunidadmedida = 0;
            Nombreunidad = string.Empty;

        }
    }
}
