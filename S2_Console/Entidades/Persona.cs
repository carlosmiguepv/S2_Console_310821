using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_Console.Entidades
{
    public class Persona
    {
        public string dni
        {
            get;
            set;
        }

        public string nombrecCompleto { get; set; }

        public int telefono { get; set; }

        public Persona()
        {

        }

        public Persona(string dni, string nombreCompleto, int telefono)
        {
            this.dni = dni;
            this.nombrecCompleto = nombrecCompleto;
            this.telefono = telefono;
        }
    
    
    }
}
