using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public class Division
    {
        public Persona encargado;
        public List<Persona> trabajadores;

        public Division(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; }
    }
}
