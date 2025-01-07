using System;

namespace ejemploAcumuladores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumuladores y contadores
            //Operador de incremento ++ y de decremento --
            //tambien sirve el contador+= variable..

            int contador = 0, acumulador = 0, e1 = 20, e2 = 13, e3 = 30;
            float promedio = 0;
            if (e1 > 18)
            {
                contador++;
                acumulador += e1;
            }

            if (e2 > 18)
            {
                contador++;
                acumulador += e2;
            }

            if (e3 > 18)
            {
                contador++;
                acumulador += e3;
            }
            promedio = acumulador / contador;
            Console.WriteLine("El contador es: " + contador);
            Console.WriteLine("El acumulador es: " + acumulador);
            Console.WriteLine("El promedio es: " + promedio);


        }
    }
}
