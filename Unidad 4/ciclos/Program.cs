namespace ciclos;

class Program
{
    static void Main(string[] args)
    {
        // 1.Hacer un programa para mostrar los números del 1 al 10.
        // No se debe realizar ningún pedido de datos.

        // Console.WriteLine("Muestra de los primeros 10 numeros. ");
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine("numero" + i);
        // }

        // 2.Hacer un programa que solicite el ingreso de 10 números 
        // y que muestre el mayor de ellos por pantalla.
        // Solo se debe emitir UN valor por pantalla.

        // int principal = 0, mayor = 0;

        // for (int i = 0; i < 5; i++) //es con 20 pero para pruebas lo hago con 5
        // {

        //     //opcion ofrecda por gpt
        //     Console.Write("Ingresa un número: ");
        //     string entrada = Console.ReadLine();

        //     // Intentamos convertir la entrada a entero
        //     if (int.TryParse(entrada, out principal)) //es necesario el if?

        //         if (i == 0)
        //         {
        //             mayor = principal;
        //         }
        //         else if (principal > mayor)
        //         {
        //             mayor = principal;
        //         }
        // }
        // Console.WriteLine("El mayor de los numeros es: " + mayor);

        // 3.Hacer un programa que solicite 20 edades y 
        // luego calcule el promedio de edad de aquellas personas mayores a 18 años.

        // int edad, acumulador = 0, contador = 0;
        // float promedio;

        // Console.WriteLine("Promedio de mayores de edad.");
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine("Ingrese la edad: ");
        //     string entrada = Console.ReadLine();
        //     int.TryParse(entrada, out edad);

        //     if (edad >= 18)
        //     {
        //         acumulador += edad;
        //         contador++;
        //     }
        // }
        // promedio = acumulador / contador;
        // Console.WriteLine("la media de edad es de: " + promedio);


        // 4.Hacer un programa que solicite UN número 
        // y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.
        // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        // Console.WriteLine("Verificador de primos (numeros)");
        // int num, cantDivisores = 0;

        // Console.WriteLine("Ingrese un número: ");
        // string entrada = Console.ReadLine();
        // int.TryParse(entrada, out num);

        // for (int i = 1; i < num; i++)
        // {
        //     if (num % i == 0)
        //     {
        //         cantDivisores++;
        //     }
        // }
        // if (cantDivisores > 2)
        // {
        //     Console.WriteLine("El numero " + num + " no es primo.");
        // }
        // else
        // {
        //     Console.WriteLine("El numero " + num + " es primo.");
        // }

        // 5.Hacer un programa que solicite 20 números y
        // luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares


        Console.WriteLine("El mayor de los pares y el menor de los impares.");

        int num, menorImpar = 0, mayorPar = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un numero");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out num);
            if (num % 2 == 0)
            {
                if (i == 0)
                {
                    mayorPar = num;
                }
                else if (num > mayorPar)
                {
                    mayorPar = num;
                }

            }
            else
            {
                if (i == 0)
                {
                    menorImpar = num;
                }
                else if (num < menorImpar)
                {
                    menorImpar = num;
                }
            }
        }
        Console.WriteLine("El mayor de los pares fue: " + mayorPar);
        Console.WriteLine("El menor de los impares fue: " + menorImpar);


    }
}
