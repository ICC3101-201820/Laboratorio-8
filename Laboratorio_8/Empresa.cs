using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        public static void Serializar(string nombreArchivo, Empresa empresa)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(nombreArchivo, FileMode.OpenOrCreate);
            binaryFormatter.Serialize(fileStream, empresa);
            fileStream.Close();
        }

        public static Empresa Deserializar(string nombreArchivo)
        {
            if (File.Exists(nombreArchivo))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream = new FileStream(nombreArchivo, FileMode.Open);
                Empresa empresa = (Empresa)binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
                return empresa;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return $"Empresa: {Nombre} ({Rut})";
        }

        public void MostrarInformacion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{this}\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Division division in divisiones)
                Console.WriteLine($"{division}\n");
        }
    }
}
