using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class TipoComprobantes
    {

        [Key]

        public int Idtipocomprobante { get; set; }
        public string Nombrecomprobante { get; set; }

        public TipoComprobantes()
        {

            Idtipocomprobante = 0;
            Nombrecomprobante = string.Empty;

        }
    }
}
