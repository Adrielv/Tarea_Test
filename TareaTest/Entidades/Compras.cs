using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Compras
    {
        [Key]
        public int Idcompra { get; set; }
        public int Idusuario { get; set; }
        public DateTime Fechacompra { get; set; }
        public int Idproveedor { get; set; }
        public int Idtipocomprobante { get; set; }
        public double Costocomprobante { get; set; }


        public Compras()
        {
            Idcompra = 0;
            Idusuario = 0;
            Fechacompra = DateTime.Now;
            Idproveedor = 0;
            Idtipocomprobante = 0;
            Costocomprobante = 0;


        }
    }
}
