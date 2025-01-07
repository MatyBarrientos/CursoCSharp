using System;

namespace programaUno
{
    class Program
    {
        static void Main()
        {

            // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión 
            // del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar 
            // el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            const int sueldo = 15000;
            float comisión = 0, total = 0;

            Console.WriteLine("Ingrese el monto que facturo su empleando en el mes: ");
            comisión = float.Parse(Console.ReadLine());

            total = (sueldo + (comisión * 0.05f));
            Console.WriteLine("El sueldo total es de: $" + total);


        }
    }
}