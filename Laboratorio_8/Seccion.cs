using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    [Serializable()]
    public class Seccion : Division
    {
        public Seccion(string nombre) : base(nombre)
        {
        }
    }
}
