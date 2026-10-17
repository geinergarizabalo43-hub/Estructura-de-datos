using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "estudiantes.csv";
 using (StreamWriter sw = new StreamWriter(ruta))
 {
 sw.WriteLine("Nombre,Edad,Nota,asignatura,transporte");
 sw.WriteLine("geiner,17,4.5,sociales,carro");
 sw.WriteLine("ingris,25,3.5,naturales,moto");
 sw.WriteLine("briandis,18,matematicas,avion");
 }
 Console.WriteLine("Archivo creado exitosamente.");
 }
}
