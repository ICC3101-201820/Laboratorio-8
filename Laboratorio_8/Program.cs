using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laboratorio_8
{
    class Program
    {
        // Lo dejamos en una variable ya que así es más fácil cambiarlo a futuro
        private const string NOMBRE_ARCHIVO = "empresa.bin";

        static void Main(string[] args)
        {
            Console.WriteLine("¿Deseas cargar datos previos?" +
                "\n[1] Sí" +
                "\n[2] No");

            string seleccion = Console.ReadLine();

            Empresa empresa = null;

            if (seleccion == "1")
            {
                if(File.Exists(NOMBRE_ARCHIVO))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream fileStream = new FileStream(NOMBRE_ARCHIVO, FileMode.Open);
                    empresa = (Empresa)binaryFormatter.Deserialize(fileStream);
                    fileStream.Close();
                }
                else
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

                // Guardamos los datos serializados en un archivo
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(NOMBRE_ARCHIVO, FileMode.OpenOrCreate);
                binaryFormatter.Serialize(fileStream, empresa);
                fileStream.Close();
            }

            Console.WriteLine("\nLos datos de la empresa son:");
            Console.WriteLine("\tNombre: " + empresa.Nombre, ConsoleColor.Red);
            Console.WriteLine("\tRut: " + empresa.Rut);
            Console.ReadKey();
        }
    }
}
