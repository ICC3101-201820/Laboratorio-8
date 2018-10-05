using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable()]
    public class Division
    {
        public Persona encargado;
        public List<Persona> trabajadores;

        public Division(string nombre)
        {
            Nombre = nombre;
            trabajadores = new List<Persona>();
        }

        public string Nombre { get; }

        public override string ToString()
        {
            string resultado = $"[{this.GetType().Name}] {Nombre}\n";

            resultado += $"\tEncargado: {encargado.Nombre}\n";
            resultado += "\tTrabajadores:";

            foreach (Persona trabajador in trabajadores)
            {
                resultado += $"\n\t\t{trabajador.Nombre} - {trabajador.Cargo}";
            }

            return resultado;
        }
    }
}
