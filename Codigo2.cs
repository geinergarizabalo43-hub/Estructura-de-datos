using System;
using System.IO;
class Program
{
 static void Main()
 
 {
string ruta = "estudiantes.csv";
if (File.Exists(ruta))
{
 string[] lineas = File.ReadAllLines(ruta);
 foreach (string linea in lineas)
 {
 string[] campos = linea.Split(',');
 Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}");
 }
}
using (StreamWriter sw = new StreamWriter("estudiantes.csv", append: true))
{
 sw.WriteLine("geiner,17,4.5");
}
 }
}
