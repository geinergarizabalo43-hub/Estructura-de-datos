Bandeja de entrada
(Sin asunto)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2. Busqueda y modificacion de informacion en vectores
            // Operaciones: Busqueda lineal, verificacion de exixtencias y actualizacion
            // de un elemto en un array.
            int[] codigos = new int[20];
            Console.WriteLine("---- ingrese el codigo ----");
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"ingrese el codigo  {i + 1}: ");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ingrese el codigo que desea actualizar: ");
                int busqueda = Convert.ToInt32(Console.ReadLine());

                int indiceEncontrada = -1;
                for (int i = 0; i < codigos.Length; i++)
                {
                    if (codigos[i] == busqueda)
                    {
                        indiceEncontrada = i;
                        break;
                    }
                }
                if (indiceEncontrada != -1)
                {
                    Console.Write("ingrese el nuevo codigo: ");
                    codigos[indiceEncontrada] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"vector actualizado: {string.Join(",", codigos)}");

                }
                else
                {

                    Console.WriteLine("error: el codigo ingresado no existe en la BDD.");
                }
                Console.WriteLine($"valor indice: {indiceEncontrada}");
           
        }
    }
}

