using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Coca-Cola:10");
            sw.WriteLine("Pepsi:15");
            sw.WriteLine("Postobon:5");
            sw.WriteLine("Sprite:20");
        }

        string[] lineas = File.ReadAllLines(ruta);
        int total = 0;
        string mayor = "";
        int cantidadMayor = 0;

        foreach (string linea in lineas)
        {
            string[] datos = linea.Split(':');
            int cantidad = int.Parse(datos[1]);

            total += cantidad;

            if (cantidad > cantidadMayor)
            {
                cantidadMayor = cantidad;
                mayor = datos[0];
            }
        }

        Console.WriteLine("Total vendido: " + total);
        Console.WriteLine("Gaseosa más vendida: " + mayor);
        Console.WriteLine("Cantidad: " + cantidadMayor);
    }
}
