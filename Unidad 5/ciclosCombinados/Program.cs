namespace ciclosCombinados;

class Program
{
    static void Main(string[] args)
    {

        // int num;
        // Console.Write("Ingrese algo: ");
        // string entrada = Console.ReadLine();
        // int.TryParse(entrada, out num);
        // Console.WriteLine("Salida de datos: " + num);

        // 1. Hacer un programa para ingresar 10 números.
        // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

        // int num;
        // Console.WriteLine("Ingrese numeros y se indica la cantidad de primos: ");
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.Write("Ingrese un numero: ");
        //     string entrada = Console.ReadLine();
        //     int.TryParse(entrada, out num);
        //     int contador = 0;
        //     for (int j = 1; j <= num; j++)
        //     {
        //         if (num % j == 0)
        //         {
        //             contador++;
        //         }
        //     }
        //     if (contador == 2)
        //     {
        //         Console.WriteLine(num + " es primo.");
        //     }
        // }



        // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
        // Se pide determinar e informar:
        //    El número de grupo con mayor porcentaje de números impares respecto
        //    al total de números que forman el grupo.
        //    Informar cuántos grupos están formados por
        //    todos números ordenados de mayor a menor.

        // int n, puntoA = 0, PuntoB = 0;
        // float porcentajeImpar, mayorPorcentajeImpar = 0;
        // for (int i = 1; i <= 5; i++)
        // {
        //     bool bandera = true;

        //     int contador = 0, cantImpares = 0;
        //     Console.WriteLine("Grupo: " + (i));
        //     Console.Write("Ingrese un numero: ");
        //     string entrada = Console.ReadLine();
        //     int.TryParse(entrada, out n);
        //     while (n != 0)
        //     {
        //         contador++;
        //         if (n % 2 != 0)
        //         {
        //             cantImpares++;
        //         }
        //         int nAnterior = n;
        //         Console.Write("Ingrese un numero: ");
        //         entrada = Console.ReadLine();
        //         int.TryParse(entrada, out n);
        //         if (nAnterior > n && n != 0)
        //         {
        //             bandera = false;
        //         }

        //     }
        //     if (bandera)
        //     {
        //         PuntoB++;
        //     }
        //     if (cantImpares > 0)
        //     {
        //         porcentajeImpar = (cantImpares * 100f) / contador;
        //     }
        //     else
        //     {
        //         porcentajeImpar = 0;
        //     }

        //     if (porcentajeImpar > mayorPorcentajeImpar)
        //     {
        //         mayorPorcentajeImpar = porcentajeImpar;
        //         puntoA = (i);
        //     }

        // }
        // Console.WriteLine("El grupo con mayor porcentaje de impares es: " + puntoA);
        // Console.WriteLine("Con un porcentaje del: " + mayorPorcentajeImpar + "%");
        // Console.WriteLine("La cantidad de grupos con numeros en escalera es de: " + PuntoB);

        // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        // El fin de la carga se notifica con un número negativo.
        // Luego mostrar cuántos números tiene cada lista.

        int n = 1;
        int grupo = 1;
        while (n >= 0)
        {
            int contador = 0;
            Console.Write("Ingrese un numero: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out n);


            while (n != 0 && n > 0)
            {
                if (n > 0)
                {
                    contador++;
                }

                Console.Write("Ingrese un numero: ");
                entrada = Console.ReadLine();
                int.TryParse(entrada, out n);
            }

            Console.WriteLine("La cantidad de numeros positivos en el grupo nro " + grupo + " es de " + contador);
            grupo++;
        }


    }
}
