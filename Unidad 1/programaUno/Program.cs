using System;

namespace programaUno
{
    class Program
    {
        static void Main(string[] args)
        {
         //paso 1: pedir valores
            //paso 2: realizar operaciones
            //paso 3: mostrar resultados
            int n1,n2, total;

            Console.WriteLine("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());
            total=n1+n2;
            Console.WriteLine("El resultado de la suma es: "+total);
    



        }
    }
}
