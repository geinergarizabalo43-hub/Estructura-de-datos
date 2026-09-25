
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; // declaracion e inizacion

            // lectura/ escritura de nuestro vector

            Console.WriteLine("---- ingreso de temperaturas ----");

            for (int i = 0;i < temperaturas.Length; i++)
            {
                Console.Write($"ingrese la temperatura de dia {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());

            }
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double t in temperaturas)
            {
                suma += t;
                if (t > maxT) maxT = t;
                if (t < minT) minT = t;
            }
            double promedio = suma / temperaturas.Length;

            //salida de inforacion
            Console.WriteLine("n----reporte-----");
            Console.WriteLine($"temperaturas registradas: {string.Join(",",temperaturas)}");
            Console.WriteLine($"temperatura promedio:{promedio:f2}°C");
            Console.WriteLine($"temperatura maxima: {maxT}°C");
            Console.WriteLine($"temperatuira minima: {minT}°C");


        }
    }
}
