internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicios de Práctica Unidad 3");

        //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
        // La resta si el primero es mayor que el segundo.
        // La suma si son iguales.
        // El producto si el primero es menor.

        // int num1, num2, resultado;

        // Console.WriteLine("Ingrese el primer valor: ");
        // num1 = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese el segundo valor: ");
        // num2 = int.Parse(Console.ReadLine());
        // if (num1 > num2)
        // {
        //     resultado = num1 - num2;
        //     Console.WriteLine("La resta de ambos numeros es de: " + resultado);
        // }
        // else if (num2 == num1)
        // {
        //     resultado = num1 + num2;
        //     Console.WriteLine("La suma de ambos numeros es de: " + resultado);
        // }
        // else
        // {
        //     resultado = num1 * num2;
        //     Console.WriteLine("El producto de ambos numeros es de: " + resultado);
        // }

        //2. Un importante negocio de desinfectante líquido realiza descuentos 
        //dependiendo de la cantidad de litros vendidos según la siguiente escala:
        // Si vende menos de 100 litros, no hay descuento.
        // Si vende entre 101 y 300 litros, el descuento es del 10%.
        // Si vende entre 301 y 500 litros, el descuento es del 15%.
        // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        // Hacer un programa que solicite el ingreso del importe total de la venta 
        //y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..


        // int cantLitros, precioLitro;
        // double precioFinal;
        // Console.WriteLine("Ingrse la cantidad de Lts vendidos: ");
        // cantLitros = int.Parse(Console.ReadLine());
        // Console.WriteLine("Ingrese el precio del Litro: ");
        // precioLitro = int.Parse(Console.ReadLine());

        // precioFinal = cantLitros * precioLitro;

        // if (cantLitros < 100)
        // {
        //     Console.WriteLine("el total a abonar es de:  " + precioFinal);
        // }
        // else if (cantLitros > 100 && cantLitros < 300)
        // {
        //     precioFinal = precioFinal * 0.9f;
        //     Console.WriteLine("el total a abonar es de:  " + precioFinal);
        // }
        // else if (cantLitros > 300 && cantLitros < 500)
        // {
        //     precioFinal = precioFinal * 0.85f;
        //     Console.WriteLine("el total a abonar es de:  " + precioFinal);
        // }
        // else
        // {
        //     precioFinal = precioFinal * 0.75f;
        //     Console.WriteLine("el total a abonar es de:  " + precioFinal);

        // }


        //3.Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
        //Para ello existe la siguiente escala de precios:
        //              i5(1)  i7(2)  i9(3)
        // 8 RAM(1)   USD 800 USD 900 USD 1200
        // 16 RAM(2)  USD 900 USD 1000    USD 1400
        // 32 RAM(3)  USD 1000    USD 1400    USD 2000
        // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea,
        //lo cual tiene un costo adicional de USD 300.Hacer un programa que solicite la opción de procesador, la opción de memoria RAM,
        //y si extiende el disco o no(ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

        int opcionProcesador, opcionRam, opcionDisco, precioFinal = 0;


        Console.WriteLine("1 - Intel Core i5. ");
        Console.WriteLine("2 - Intel Core i7. ");
        Console.WriteLine("3 - Intel Core i9. ");
        Console.WriteLine("Seleccione una opcion de Procesador: ");
        opcionProcesador = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - 8GB. ");
        Console.WriteLine("2 - 16GB. ");
        Console.WriteLine("3 - 32GB. ");
        Console.WriteLine("Seleccione una opcion de Memoria Ram: ");
        opcionRam = int.Parse(Console.ReadLine());

        Console.WriteLine("El almacenamiento es de 500GB.");
        Console.WriteLine("Desea extenderlo a 1TB? (1-si | 2-no): ");
        opcionDisco = int.Parse(Console.ReadLine());


        if (opcionDisco == 0)
        {
            precioFinal += 0;
        }
        else
        {
            precioFinal += 300;
        }

        switch (opcionProcesador)
        {
            case 1:
                //i5
                switch (opcionRam)
                {
                    case 1:
                        //8GB
                        precioFinal += 800;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i5.");
                        Console.WriteLine("Memoria ram -> 8GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 2:
                        //16GB
                        precioFinal += 900;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i5.");
                        Console.WriteLine("Memoria ram -> 16GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 3:
                        //32GB
                        precioFinal += 1000;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i5.");
                        Console.WriteLine("Memoria ram -> 32GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                }
                break;
            case 2:
                //i7
                switch (opcionRam)
                {
                    case 1:
                        //8GB
                        precioFinal += 900;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i7.");
                        Console.WriteLine("Memoria ram -> 8GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 2:
                        //16GB
                        precioFinal += 1000;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i7.");
                        Console.WriteLine("Memoria ram -> 16GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 3:
                        //32GB
                        precioFinal += 1400;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i7.");
                        Console.WriteLine("Memoria ram -> 32GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                }
                break;
            case 3:
                //i9
                switch (opcionRam)
                {
                    case 1:
                        //8GB
                        precioFinal += 1200;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i9.");
                        Console.WriteLine("Memoria ram -> 8GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 2:
                        //16GB
                        precioFinal += 1400;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i9.");
                        Console.WriteLine("Memoria ram -> 16GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                    case 3:
                        //32GB
                        precioFinal += 2000;
                        Console.WriteLine("Caracteristicas del equipo adquirido:");
                        Console.WriteLine("Procesador -> Intel Core i9.");
                        Console.WriteLine("Memoria ram -> 32GB.");
                        if (opcionDisco == 0)
                        {
                            Console.WriteLine("Almacenamiento -> 500GB");
                        }
                        else
                        {
                            Console.WriteLine("Almacenamiento -> 1TB");
                        }
                        Console.WriteLine("El precio final a pagar es de: " + precioFinal);
                        break;
                }
                break;

        }




    }
}