using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Materno { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public int Idimagen { get; set; }
        public string Direccion { get; set; }
        public int Idtipopersona { get; set; }

        public Personas()
        {
            PersonaId = 0;
            Dni = 0;
            Nombre = string.Empty;
            Materno = string.Empty;
            Paterno = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Sexo = string.Empty;
            Idimagen = 0;
            Direccion = string.Empty; ;
            Idtipopersona = 0;

        }
    }
}
