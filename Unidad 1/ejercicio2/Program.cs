// See https://aka.ms/new-console-template for more information
using System;

namespace programaUno
{
    class Program
    {
        static void Main()
        {
            // 2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            int numero, potencia;
            Console.WriteLine("Ingrese el valor a calcular: ");
            numero = int.Parse(Console.ReadLine());
            potencia = numero * numero * numero;
            Console.WriteLine("El valor de " + numero + " elevado al cubo es de: " + potencia);



        }
    }
}