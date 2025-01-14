namespace vectores;

class Program
{
    static void Main(string[] args)
    {
        //1.Hacer un programa que solicite 10 números enteros y los guarde en un vector.
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        // Console.WriteLine("Ejercicio Nro 1");
        // int[] numeros = new int[10];
        // int maxValor = 0, pos = 0;

        // for (int i = 0; i < 10; i++)
        // {
        //     string entrada = Console.ReadLine();
        //     int.TryParse(entrada, out numeros[i]);
        // }
        // for (int j = 0; j < 10; j++)
        // {
        //     if (j == 0)
        //     {
        //         maxValor = numeros[j];
        //         pos = j;
        //     }
        //     else if (numeros[j] > maxValor)
        //     {
        //         maxValor = numeros[j];
        //         pos = j;
        //     }
        // }
        // Console.WriteLine("El mayor valor encontrado fue de: " + maxValor + ", en la posicion " + (pos + 1));

        // 2.Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

        // Console.WriteLine("Ejercicio nro 2");
        // int[] enteros = new int[10];
        // float promedio = 0;

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write("Ingrese un valor: ");
        //     string entrada = Console.ReadLine();
        //     int.TryParse(entrada, out enteros[i]);
        //     promedio += enteros[i];
        // }
        // promedio = (promedio / 10);
        // Console.WriteLine("El promedio del vector es de: " + promedio);

        // for (int j = 0; j < 10; j++)
        // {
        //     if (enteros[j] > promedio)
        //     {
        //         Console.WriteLine(enteros[j] + " es mayor que el promedio.");
        //     }
        // }



        // 3.Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos(tres ingresos).
        //  El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
        //   Mostrar el resultado en pantalla.Ejemplo:
        // CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        // CADENA RESULTADO: “Li mir estibi sereni"

        // Console.Write("Ingrese una frase: ");
        // string frase = Console.ReadLine();
        // // Console.WriteLine(frase);
        // int tam = frase.Length;
        // char[] cadena = new char[tam];

        // char caracterA, caracterB;

        // Console.Write("Ingrese un caracter a buscar: ");
        // caracterA = char.Parse(Console.ReadLine());
        // Console.Write("Ingrese un caracter a cambiar: ");
        // caracterB = char.Parse(Console.ReadLine());

        // for (int i = 0; i < tam; i++)
        // {
        //     cadena[i] = frase[i];
        // }
        // for (int j = 0; j < tam; j++)
        // {
        //     if (cadena[j] == caracterA)
        //     {
        //         cadena[j] = caracterB;
        //     }
        // }
        // Console.Write("Cambios de caracteres: ");
        // Console.Write(cadena);


        // 4.Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // -Número de Artículo(1 a 15)
        // -Cantidad Vendida
        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.


    }
}
