using System;

namespace programaUno
{
    class Program
    {
        static void Main()
        {
            // 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            float distancia, movil, tiempo;
            Console.WriteLine("Ingrese la distancia entra la Gotham y Metropolis: ");
            distancia = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad (en km/hs) de su vehículo: ");
            movil = float.Parse(Console.ReadLine());
            tiempo = distancia / movil;

            Console.WriteLine("El tiempo estimado es de: " + tiempo);



        }
    }
}