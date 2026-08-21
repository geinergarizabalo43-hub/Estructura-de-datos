using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pp
{

    internal class Program
    {
        static void ImprimirCabezera(string nombreMateria, int grupo, string nombreEstudiante, string nombreMama, int edad, string diaClases, string trabajo)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine($" Asignatura: {nombreMateria}");
            Console.WriteLine($" Grupo: {grupo}");
            Console.WriteLine($" Nombre del estudiante : {nombreEstudiante}");
            Console.WriteLine($" nombre de la mama: {nombreMama}");
            Console.WriteLine($" edad: {edad}");
            Console.WriteLine($" dia de clases: {diaClases}");
            Console.WriteLine($" trabajo: {trabajo}");
            Console.WriteLine("===========================================");
        }
        public static void Main(string[] args) {
            //llamar a la procedimiento ImprimirCabezera
            ImprimirCabezera("fundamentos de Programacion", 1, "Geiner Andres Garizabalo Ayala", "Ingrith Judith Ayala Corrales", 17, "viernes", "SI");

        }
    }
}
