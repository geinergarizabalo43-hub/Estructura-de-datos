Elementos enviados
(Sin asunto)
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
            //una tienda registra las ventas de 10 dias en una array double[]
            //y necesita calcular:
            //1.calcular el total vendido
            //2.calcular el promedio diario
            //3.encontara el dia con mayor ventas
            //4.encontrar el dia con menos venta
            //5.contar cuantos dias superaron el promedio
            double[] ventas = { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211 };
            double total = 0;
            double mayorventa = ventas[0];
            double menorventa = ventas[0];
            int diamayorventa = 0;
            int diamenorventa = 0;

            for (int i = 0;i < ventas.Length; i++)
            {
                total += ventas[i];

                if (ventas[i] > mayorventa)
                {
                    mayorventa = ventas[i];
                    diamayorventa = i;
                }
                if (ventas[i] < menorventa)
                {
                    menorventa = ventas[i];
                    diamenorventa = i;
                }



            }
            double promedio = total / ventas.Length;
            int diassobrepromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
            {

                if (ventas[i] > promedio)
                {
                    diassobrepromedio++;

                }
            }

            Console.WriteLine("================== REPORTE DE VENTAS ===============");
            Console.WriteLine();


            Console.WriteLine($"total vendio: ${total:F3}");
            Console.WriteLine($"promedio diario: ${promedio:F3}");
            Console.WriteLine();

            Console.WriteLine($"mayor venta ${mayorventa:F3} - el dia {diamayorventa + 1}");
            Console.WriteLine($"menor venta ${menorventa:F3} - el dia {diamenorventa + 1}");

            Console.WriteLine($"dias que superaron el promedio de ventas: ${diassobrepromedio}");
            Console.WriteLine();

            for(int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"dia {i + 1}: ${ventas[i]}");
            }






















        }
    }
}
