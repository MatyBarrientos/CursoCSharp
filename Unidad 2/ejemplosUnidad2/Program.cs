using System;
using System.Data;

namespace ejemplosUnidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque if: Condicionales if, else if, else
            //Operadores logicos && and, || or, ! not
            //Operadores relaciones < menor, >mayor, <= menor o igual, >= mayor o igual, == igual, != distinto
            int edad = 32;

            if (edad >= 21)
            {
                if (edad >= 30)
                    Console.WriteLine("El descuento es del 30%");
                else
                    Console.WriteLine("Descuento del 21%");
            }
            else
                Console.WriteLine("No tenés descuentos");
            Console.WriteLine("Fin del programa");
        }
    }
}
