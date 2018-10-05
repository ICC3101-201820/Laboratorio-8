using System;
using System.Collections.Generic;

namespace Laboratorio_8
{
    [Serializable()]
    public class Empresa
    {
        public List<Division> divisiones;

        public Empresa(string nombre, string rut)
        {
            this.Nombre = nombre;
            this.Rut = rut;
            divisiones = new List<Division>();
        }

        public string Nombre { get; }
        public string Rut { get; }
    }
}
