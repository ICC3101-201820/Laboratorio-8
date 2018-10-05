using System;

namespace Laboratorio_8
{
    public class Program
    {
        // Lo dejamos en una variable ya que así es más fácil cambiarlo a futuro
        private const string NOMBRE_ARCHIVO = "empresa.bin";

        public static void Main(string[] args)
        {
            Console.WriteLine("¿Deseas cargar datos previos?" +
                "\n[1] Sí" +
                "\n[2] No");

            string seleccion = Console.ReadLine();

            Empresa empresa = null;

            if (seleccion == "1")
            {
                empresa = Empresa.Deserializar(NOMBRE_ARCHIVO);

                if (empresa == null)
                {
                    Console.WriteLine("No hay registros guardados de la empresa");
                }
            }

            /** 
             * Si seleccion == "2", entonces empresa será null.
             * Si seleccion == "1" y el archivo no existe, entonces empresa será null.
             * Por ende, la siguiente condición es suficiente (y no requerimos verificar el valor de selección)
             */
            if (empresa == null)
            {
                // Solicitamos datos al usuario
                Console.WriteLine("Ingrese el nombre de la empresa:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el rut de la empresa");
                string rut = Console.ReadLine();
                empresa = new Empresa(nombre, rut);

                Area area = new Area("Ingeniería");
                area.encargado = new Persona("Matías", "Recabarren", "", "Jefe");
                area.trabajadores.Add(new Persona("Nicolás", "Gómez", "", "Profesor"));
                area.trabajadores.Add(new Persona("Ignacio", "Figueroa", "", "Ayudante"));
                area.trabajadores.Add(new Persona("Sebastían", "Baixas", "", "Ayudante"));

                Departamento departamento = new Departamento("Ciencias de la computación");
                departamento.encargado = new Persona("Steve", "Wozniak", "", "Director");
                departamento.trabajadores.Add(new Persona("Luke", "Skywalker", "", "Jedi"));
                departamento.trabajadores.Add(new Persona("Darth", "Vader", "", "Sith"));

                area.departamentos.Add(departamento);

                Seccion seccion1 = new Seccion("Informática");
                seccion1.encargado = new Persona("James", "Cole", "", "Time traveler");
                seccion1.trabajadores.Add(new Persona("Cassie", "", "", "Doctora"));
                seccion1.trabajadores.Add(new Persona("Johnson", "", "", "Científica"));

                Seccion seccion2 = new Seccion("Seguridad");
                seccion2.encargado = new Persona("Chama", "Alonso", "", "Hacker");
                seccion2.trabajadores.Add(new Persona("Alex", "Smith", "", "Hacker Antorcha"));
                seccion2.trabajadores.Add(new Persona("Kevin", "Mitnick", "", "Hacker Famoso"));

                departamento.secciones.Add(seccion1);
                departamento.secciones.Add(seccion2);

                empresa.divisiones.Add(area);
                empresa.divisiones.Add(departamento);
                empresa.divisiones.Add(seccion1);
                empresa.divisiones.Add(seccion2);

                // Guardamos los datos serializados en un archivo
                Empresa.Serializar(NOMBRE_ARCHIVO, empresa);
            }

            empresa.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
