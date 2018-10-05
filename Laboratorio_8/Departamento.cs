using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public class Departamento : Division
    {
        public List<Seccion> secciones;

        public Departamento(string nombre) : base(nombre)
        {
            secciones = new List<Seccion>();
        }
    }
}
