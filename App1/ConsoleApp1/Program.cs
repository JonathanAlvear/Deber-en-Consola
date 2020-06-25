using System;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Listado de notas de alumnos del paralelo B");
            Console.WriteLine("Nombres y apellidos");
            Console.WriteLine("Maria Adriana Castillo Cevallos");
            int notaPrimerParcial = 75;
            int notaSegundoParcial = 20;
            int notaFinal = notaPrimerParcial + notaSegundoParcial;
            Console.WriteLine( notaFinal + "/100");

            Console.WriteLine("Nombres y apellidos");
            Console.WriteLine("Jhon Leonardo Mendoza Zurita");
            int notaPrimerParcial1 = 40;
            int notaSegundoParcial1 = 15;
            int notaFinal1 = notaPrimerParcial1 + notaSegundoParcial1;
            Console.WriteLine(notaFinal1 + "/100");

            Console.WriteLine("Nombres y apellidos");
            Console.WriteLine("Carlos Alexander Tenorio Rocafuerte");
            int notaPrimerParcial2 = 40;
            int notaSegundoParcial2 = 15;
            int notaFinal2 = notaPrimerParcial2 + notaSegundoParcial2;
            Console.WriteLine(notaFinal2 + "/100");
            Console.ReadKey();
        }
    }
}
