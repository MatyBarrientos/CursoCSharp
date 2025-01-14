namespace ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        // 1.Hacer una función llamada “producto” que reciba dos números enteros
        // y que devuelva el producto de ambos. 
        // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida
        // y muestre por pantalla el monto total a pagar. Usar la función.

        int precio = 0, cantidad = 0, total;
        pedirDatos(ref precio, "Ingrese el precio: ");
        pedirDatos(ref cantidad, "Ingrese la cantidad: ");
        total = producto(precio, cantidad);

        Console.WriteLine("El monto a pagar es de: " + total);




    }

    static void pedirDatos(ref int a, string mjs)
    {
        Console.Write(mjs);
        string entrada = Console.ReadLine();
        int.TryParse(entrada, out a);
    }

    static int producto(int a, int b)
    {
        return a * b;
    }
}
