using System;
using System.IO;
class Program
{
 static void Main()
 {
 string ruta = "repuestos.csv";
 using (StreamWriter sw = new StreamWriter(ruta))
 {
 sw.WriteLine("ID,Nombre,Precio,lugar,unidades");
 sw.WriteLine("1,tablet,12000,tasajera,20");
 sw.WriteLine("2,celular,800,cienaga,35");
 sw.WriteLine("3,computador,600,santa marta,100");
 }
 string[] lineas = File.ReadAllLines(ruta);
 for (int i = 1; i < lineas.Length; i++)
 {
 string[] almacen = lineas[i].Split(',');
 double precio = double.Parse(almacen[2]);
 if (precio > 500)
 Console.WriteLine($"{almacen[1]} - ${precio}");
 }
 }
}
