using System;

namespace ejerciciosTres
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa para ingresar un número y luego se 
            // emita por pantalla un cartel aclaratorio si “Es mayor a 10” o 
            // “No es mayor a 10”.

            // Console.WriteLine("Ingrese un número para verificar si es mayor a 10: ");
            // int numero = int.Parse(Console.ReadLine());
            // if (numero > 10)
            // {
            //     Console.WriteLine("El numéro ingresa es mayor a 10");
            // }
            // else if (numero == 10)
            // {
            //     Console.WriteLine("El número es 10");
            // }
            // else
            // {
            //     Console.WriteLine("No es mayor a 10");
            // }

            //2. Hacer un programa para ingresar un número
            //y luego se emita un cartel por pantalla
            // “Positivo” si el número es mayor a cero,
            //  “Negativo” si el número es menor a cero o
            //   “Cero” si el número es igual a cero.

            // Console.WriteLine("Ingrese un número para ver su carga: ");
            // int numero = int.Parse(Console.ReadLine());
            // if (numero > 0)
            // {
            //     Console.WriteLine("Es número positivo. ");
            // }
            // else if (numero == 0)
            // {
            //     Console.WriteLine("El número es *0* ");
            // }
            // else
            // {
            //     Console.WriteLine("El número es negativo. ");
            // }

            //3.Una casa de video juegos otorga un descuento
            //dependiendo del importe de la compra realizada
            //según los siguientes valores:
            //*Si el importe es menor a ARS 1000, no hay descuento.
            //* Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.
            //* Si el importe es ARS 5000 o más, aplica un descuento del 18 %.

            // double precio, valorFinal;
            // Console.WriteLine("Ingrese el monto final de la compra: ");
            // precio = float.Parse(Console.ReadLine());

            // if (precio < 5000 && precio >= 1000)
            // {
            //     valorFinal = precio * 0.9f;
            // }
            // else if (precio >= 5000)
            // {
            //     valorFinal = precio * 0.82;
            // }
            // else
            // {
            //     valorFinal = precio;
            // }
            // Console.WriteLine("El precio final a pagar por tu compra de " + precio + " es de: " + valorFinal);

            // 4. Hacer un programa para ingresar cuatro números distintos 
            // y luego mostrar por pantalla el menor de ellos.

            // int num1, num2, num3, num4;

            // Console.WriteLine("Ingrese el 1er valor: ");
            // num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el 2do valor: ");
            // num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el 3er valor: ");
            // num3 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese el 4to valor: ");
            // num4 = int.Parse(Console.ReadLine());


            // if (num1 < num2 && num1 < num3 && num1 < num4)
            // {
            //     Console.WriteLine("El menor de los ingresados es el primero: " + num1);
            // }
            // else if (num2 < num1 && num2 < num3 && num2 < num4)
            // {
            //     Console.WriteLine("El menor de los ingresados es el segundo : " + num2);
            // }
            // else if (num3 < num1 && num3 < num2 && num3 < num4)
            // {
            //     Console.WriteLine("El menor de los ingresados es el tercero: " + num3);
            // }
            // else
            // {
            //     Console.WriteLine("El menor de los ingresados es el cuarto: " + num4);
            // }

            // 5. Hacer un programa para ingresar cuatro números
            //  y luego mostrar por pantalla cuáles son mayores a 100.

            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese el 1er valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er valor: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 4to valor: ");
            num4 = int.Parse(Console.ReadLine());

            if (num1 > 100)
            {
                Console.WriteLine("El primer número " + num1 + ",Es mayor a 100");
            }
            if (num2 > 100)
            {
                Console.WriteLine("El segundo numero " + num2 + ",Es mayor a 100");
            }
            if (num3 > 100)
            {
                Console.WriteLine("El tercer numero " + num3 + ",Es mayor a 100");
            }
            if (num4 > 100)
            {
                Console.WriteLine("El cuarto numero " + num4 + ",Es mayor a 100");
            }


        }
    }
}
