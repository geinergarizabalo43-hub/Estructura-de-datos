using System;
using System.Collections.Generic;
using System.IO;


// Registros de incidencias de soporte tecnico utilizando archivos (.txt)
// 1. Guardar en una lista de incidencias atendidas en un archivo de texto (incidencias. txt)
// 2. leer el archivo
// 3. Generar un reporte que cueta cuantas incidencias hay por prioridad (Alta, Media, Baja).
// la estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.
namespace registrosIncidenciales
{
    internal class Program
    {
        // creado ruta para guardar mis incidencias
        static string pathArchivo = "incidencias. txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {
                        sw.WriteLine(incidencias);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
        }

        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (File.Exists(pathArchivo))
            {
                Console.WriteLine("EL Archivo no existe aun.");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo))
                {
                    while ((linea = sr.ReadLine()) != null)
                    {

                        if (!string.IsNullOrWhiteSpace(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir el archivo: {ex.Message}");
            }
            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if(incidencias.Count == 0)
            {
                Console.WriteLine("no hay incidencias para reportar.");
                return;
            }

            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();
           
            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //inc['01'; 'geiner'; 'daño del pc';'alta']
                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;
                }
                else
                    conteoPorPrioridad[prioridad] = 1;

            }

            Console.WriteLine("\n reporte incidentes");
            Console.WriteLine($"total atendidas: {incidencias.Count}");
            Console.WriteLine("detalle por prioridad");
            foreach (var inc in conteoPorPrioridad)
                Console.WriteLine($"\nprioridad {inc.Key}:{inc.Value}");





        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[]{"1","geiner garizabalo","no imprime","alta"},
                new string[]{"2","ingris ayala","olvido contraseña","baja"},
                new string[]{"3","andres herrera","wifi lento","alta"},
                new string[]{"4","keiner ","pantalla azul","media"},
                new string[]{"5","briandis","no enciemde pc","alta"},

            };

            Console.WriteLine("registro de incidencias unicaribe");
            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n --- leyendo incidencias del archivo ---");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n listado de incidencias leidas:");
            Console.WriteLine($"{"ID",-4}{"usuario",-15}{"descripcion",-20}{"prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4} {inc[1],-15} {inc[2],-20} {inc[3],-10}");
            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\norecione cualquier tecla para salir !!!!");
            Console.ReadKey();




        }
    }
}
