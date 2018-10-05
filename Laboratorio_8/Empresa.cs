using System;

namespace Laboratorio_8
{
    [Serializable()]
    public class Empresa
    {
        public Empresa(string nombre, string rut)
        {
            this.Nombre = nombre;
            this.Rut = rut;
        }

        public string Nombre { get; }
        public string Rut { get; }
    }
}
