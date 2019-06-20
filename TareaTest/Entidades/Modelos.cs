using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Modelos
    {
        [Key]
        public int Idmodelo { get; set; }
        public string Nombremodelo { get; set; }

        public Modelos()
        {
            Idmodelo = 0;
            Nombremodelo = string.Empty;

        }
    }
}
