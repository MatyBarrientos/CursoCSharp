using System;

namespace programaUno
{
    class Program
    {
        static void Main()
        {

            // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y 
            // luego calcule y emita por pantalla el promedio final

            float nota1 = 0, nota2 = 0, nota3 = 0, promedio = 0;
            Console.WriteLine("Ingrese la nota nro 1: ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota nro 2: ");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota nro 3: ");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio del Alumno es de: " + promedio);
        }
    }
}