Elementos enviados
(Sin asunto)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametros
{
    internal class Program
    {    
        //procedimiento sumar e imprimir
        public static void ImprimirSuma(int a, int b)
        {
            //a, b son los parametros
            int suma = a + b;
            Console.WriteLine(suma);
        }
        public static void MostrarPotenciaX(double num1, double potencia)
        {
            double result = Math.Pow(num1, potencia);
            Console.WriteLine($"la pontencia de {num1} elevado a {potencia} es: {result}");

        }
        static void ModificarValor(int n)
        {
            n = n + 1;
            Console.WriteLine($"Dentro del metodo:{n}");
        }
       
        static void Main(string[] args)
        {
            int x = 12, y = 23;

            ImprimirSuma(y, x); //y, x (Arguentos Actuales)
            ImprimirSuma(1000, -1); //1000, -1 (Argumentos Literales)
            MostrarPotenciaX(x, y);
           
            int edad = 17;
            Console.WriteLine($"Antes del metodo:{edad}");
            ModificarValor(edad);
            Console.WriteLine($"Despues del metodo:{edad}");




        }
    }
}
