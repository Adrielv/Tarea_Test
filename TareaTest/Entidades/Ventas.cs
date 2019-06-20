using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Ventas
    {
        [Key]
        public int Idventa { get; set; }
        public int Idusuario { get; set; }
        public int Idcliente { get; set; }
        public int Idtipocomprobante { get; set; }
        public DateTime Fechaventa { get; set; }
      
        public double Igv { get; set; }
        public double SubTotal { get; set; }
        public double Costoventa { get; set; }

        public Ventas()
        {
            Idventa = 0;
            Idusuario = 0;
            Idcliente = 0;
            Idtipocomprobante = 0;
           Fechaventa = DateTime.Now;
            Igv = 0;
           SubTotal = 0;
            Costoventa = 0;

        }

    }
}
