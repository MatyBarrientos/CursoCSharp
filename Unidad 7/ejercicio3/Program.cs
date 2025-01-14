namespace ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        // 3.Hacer una función llamada “primo” que reciba un número entero
        // y devuelva 1 si el número es primo o cero si no lo es.
        // Hacer un programa para ingresar números.
        // El lote corta cuando se ingresa un número cero.
        // Informar el promedio teniendo en cuenta sólo los números primos.

        int num = 0, contador = 0, acumulador = 0;
        pedirDatos(ref num, "Ingrese un valor: ");
        while (num != 0)
        {
            if (primo(num) == 1)
            {
                contador++;
                acumulador += num;
            }
            pedirDatos(ref num, "Ingrese un valor: ");

        }
        float promedio = acumulador / contador;
        Console.WriteLine("La cantidad de primos es de: " + contador);
        Console.WriteLine("el promedio de los numeros primos es de: " + promedio);
    }

    static void pedirDatos(ref int a, string mjs)
    {
        Console.Write(mjs);
        string entrada = Console.ReadLine();
        int.TryParse(entrada, out a);
    }

    static int primo(int num)
    {
        int valor = 0, contador = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contador++;
            }
        }
        return valor = contador == 2 ? 1 : 0;
    }
}
