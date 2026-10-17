using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "productos.csv";

        // Crear el archivo CSV
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,Coca-Cola,3500");
            sw.WriteLine("2,Pepsi,3000");
            sw.WriteLine("3,Postobon,2500");
            sw.WriteLine("4,Sprite,3200");
        }

        // Leer el archivo CSV
        string[] lineas = File.ReadAllLines(ruta);

        Console.WriteLine("Gaseosas con precio mayor a $3000:");

        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            double precio = double.Parse(campos[2]);

            if (precio > 10)
            {
                Console.WriteLine($"{campos[1]} - ${precio}");
            }
        }
    }
}
