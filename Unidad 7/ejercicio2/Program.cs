namespace ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
        //  Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        Console.WriteLine("Contador de pares.");
        int contador = 0, valor = 0;

        for (int i = 0; i < 10; i++)
        {
            pedirDatos(ref valor, "Ingrese un numero: ");
            if (par(valor) == 1)
                contador++;
        }
        Console.WriteLine("La cantidad de valor pares es de: " + contador);
    }

    static int par(int num)
    {
        int retorno = num % 2 == 0 ? 1 : 0;
        return retorno;
    }
    static void pedirDatos(ref int a, string mjs)
    {
        Console.Write(mjs);
        string entrada = Console.ReadLine();
        int.TryParse(entrada, out a);
    }
}
