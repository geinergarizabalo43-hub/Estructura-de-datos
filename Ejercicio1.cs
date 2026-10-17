using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "productos.csv";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,Coca-Cola,3500");
            sw.WriteLine("2,Pepsi,3000");
            sw.WriteLine("3,Postobon,2500");
            sw.WriteLine("4,Sprite,3200");
        }

        string[] lineas = File.ReadAllLines(ruta);
        char delimitador = ',';

        string[] campos = lineas[0].Split(delimitador);

        Console.WriteLine("Delimitador: " + delimitador);
        Console.WriteLine("Campos:");

        foreach (string campo in campos)
            Console.WriteLine(campo);

        Console.WriteLine("Tipos de datos:");

        string[] datos = lineas[1].Split(delimitador);

        for (int i = 0; i < campos.Length; i++)
        {
            string tipo = int.TryParse(datos[i], out _)
                ? "Entero" : "Texto";

            Console.WriteLine(campos[i] + ": " + tipo);
        }
    }
}
