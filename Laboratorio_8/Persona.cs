using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable()]
    public class Persona
    {
        public Persona(string nombre, string apellido, string rut, string cargo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Rut = rut;
            this.Cargo = cargo;
        }

        public string Nombre { get; }
        public string Rut { get; }
        public string Apellido { get; }
        public string Cargo { get; }
    }
}
