using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public class Area : Division
    {
        public List<Departamento> departamentos;

        public Area(string nombre) : base(nombre)
        {
            departamentos = new List<Departamento>();
        }
    }
}
