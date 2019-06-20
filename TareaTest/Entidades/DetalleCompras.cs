using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class DetalleCompras
    {
        [Key]
        public int Iddetallecompra { get; set; }
        public int Idcompra { get; set; }
        public int Idproducto { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double Total { get; set; }

        public DetalleCompras()
        {
            Iddetallecompra = 0;
            Idcompra = 0;
            Idproducto = 0;
            Unidades = 0;
            Costounidad = 0;
            Total = 0;

        }
    }
}
